using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;

namespace RegexpPracticeApp{
    class RegexpDB : IDisposable{
        const int ALL_MATCH = 1;
        const int GROUP_MATCH = 2;
        private SQLiteConnection con = null;
        private DataTable dataTable = null;

        public RegexpDB() {
            dataTable = new DataTable();
            string dbName = Properties.Resources.dbName;
            string dbPassWord = Properties.Resources.dbPassWord;
            con = new SQLiteConnection("Data Source = " + dbName + ";password=" + dbPassWord);
            con.Open();

            using (SQLiteCommand cmd = con.CreateCommand()) {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProblemList(string problemId) {
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        string sql = "DELETE FROM [problemList] WHERE [id] = " + problemId + ";";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                } catch (Exception ex) {
                    throw ex;

                }
            }
        }

        public void LoadTitleList(DataGridView dgvProblemList) {
            dgvProblemList.DataSource = "";

            //button列を削除する
            while (0 < dgvProblemList.Columns.Count) {
                dgvProblemList.Columns.RemoveAt(0);
            }

            ////ボタンを追加
            DataGridViewImageColumn dgvColumnSelect = new DataGridViewImageColumn();
            dgvColumnSelect.Name = "選択";
            dgvColumnSelect.Image = new Bitmap(Properties.Resources.dgv_edit);
            dgvColumnSelect.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvProblemList.Columns.Add(dgvColumnSelect);
            dgvProblemList.Columns[dgvProblemList.Columns.Count - 1].Width = 50;


            dgvProblemList.DataSource = dataTable;
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT id, level AS [難易度], title AS [タイトル] FROM problemList", con)) {
                adapter.Fill(dataTable);
            }

            dgvProblemList.Columns["id"].Visible = false;
            dgvProblemList.Columns["難易度"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProblemList.Columns["タイトル"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
            DataGridViewImageColumn dgvColumnEdit = new DataGridViewImageColumn();
            dgvColumnEdit.Name = "編集";
            dgvColumnEdit.Image = new Bitmap(Properties.Resources.dgv_edit);
            dgvColumnEdit.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvProblemList.Columns.Add(dgvColumnEdit);
            dgvProblemList.Columns[dgvProblemList.Columns.Count - 1].Width = 50;


            DataGridViewImageColumn dgvColumnDelete = new DataGridViewImageColumn();
            dgvColumnDelete.Name = "削除";
            dgvColumnDelete.Image = new Bitmap(Properties.Resources.dgv_delete);
            dgvColumnDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvProblemList.Columns.Add(dgvColumnDelete);
            dgvProblemList.Columns[dgvProblemList.Columns.Count - 1].Width = 50;

            dgvProblemList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248,185,81);

            if (0 < dgvProblemList.Rows.Count) {
                dgvProblemList[3, 0].Selected = true;
            }
            
        }

        public void InsertRegexpProblem(string title, string problem, string data, string answer, int level, MatchCollection matches) {
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    using (SQLiteCommand cmd = con.CreateCommand()) {

                        //ProblemListテーブルに追加
                        this.InsertProblemListTable(cmd, title, problem, data, answer, level);
                        //IDを取得
                        int problem_id = last_insert_id(cmd, "problemList");

                        //matchDataテーブルに追加
                        foreach (Match match in matches) {
                            //全体マッチ
                            int index = match.Groups[0].Index;
                            int length = match.Groups[0].Length;

                            //matchDataテーブルに追加(全体マッチ)
                            this.InsertMatchDataTable(cmd, problem_id, ALL_MATCH, index, length);

                            for (int i = 1; i < match.Groups.Count; i++) {
                                //部分マッチ
                                index = match.Groups[i].Index;
                                length = match.Groups[i].Length;

                                //matchDataテーブルに追加(グループマッチ)
                                this.InsertMatchDataTable(cmd, problem_id, GROUP_MATCH, index, length);
                            }
                        }
                    }

                    trans.Commit();
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        private void InsertMatchDataTable(SQLiteCommand cmd, int problem_id, int type, int matchIndex, int matchLength) {
            
            string sql = "INSERT INTO [matchData] " +
                           "(problem_id, type, matchIndex, matchLength) " +
                           "VALUES(@problem_id, @type, @matchIndex, @matchLength);";

            cmd.CommandText = sql;

            cmd.Parameters.Add("problem_id", System.Data.DbType.Int32);
            cmd.Parameters["problem_id"].Value = problem_id;

            cmd.Parameters.Add("type", System.Data.DbType.Int32);
            cmd.Parameters["type"].Value = type;

            cmd.Parameters.Add("matchIndex", System.Data.DbType.Int32);
            cmd.Parameters["matchIndex"].Value = matchIndex;

            cmd.Parameters.Add("matchLength", System.Data.DbType.Int32);
            cmd.Parameters["matchLength"].Value = matchLength;

            cmd.ExecuteNonQuery();
        }

        private void InsertProblemListTable(SQLiteCommand cmd, string title, string problem, string data, string answer, int level) {
            
            string sql = "INSERT INTO [problemList] " +
                           "([title], [problem], [data], [answer], [level], [ctime], [mtime]) " +
                           "VALUES(@title, @problem, @data, @answer, @level, @ctime, @mtime);";

            //problemListテーブルに追加
            cmd.CommandText = sql;

            cmd.Parameters.Add("title", System.Data.DbType.String);
            cmd.Parameters["title"].Value = title;

            cmd.Parameters.Add("problem", System.Data.DbType.String);
            cmd.Parameters["problem"].Value = problem;

            cmd.Parameters.Add("data", System.Data.DbType.String);
            cmd.Parameters["data"].Value = data;

            cmd.Parameters.Add("answer", System.Data.DbType.String);
            cmd.Parameters["answer"].Value = answer;

            cmd.Parameters.Add("level", System.Data.DbType.Int32);
            cmd.Parameters["level"].Value = level;

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.Add("ctime", System.Data.DbType.String);
            cmd.Parameters["ctime"].Value = currentTime;

            cmd.Parameters.Add("mtime", System.Data.DbType.String);
            cmd.Parameters["mtime"].Value = currentTime;

            cmd.ExecuteNonQuery();
        }

        public int last_insert_id(SQLiteCommand cmd, string tableName) {
            cmd.CommandText = "select last_insert_rowid();";
            string rowid = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "select id from " + tableName + " WHERE rowid = " + rowid + ";";
            return int.Parse(cmd.ExecuteScalar().ToString());
        }

        public void Dispose() {
            con.Close();
        }
    }
}
