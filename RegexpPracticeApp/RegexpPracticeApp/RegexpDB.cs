using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Reflection;

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

        public void LoadData(string id, TextBox tbTitle, TextBox tbProblem,RichTextBox rtbResult, TextBox tbAnswer, TextBox tbLevel) {
            using (SQLiteCommand cmd = con.CreateCommand()) {
                //IDが存在するかチェック
                string sql = "";
                sql = "SELECT COUNT(*) FROM [problemList] WHERE [id] = @id;";
                cmd.CommandText = sql;
                cmd.Parameters.Add("id", System.Data.DbType.Int32);
                cmd.Parameters["id"].Value = id;
                cmd.Prepare();

                if (Convert.ToInt32(cmd.ExecuteScalar()) != 1) {
                    throw new RegexpPracticeException("データベースに、編集しようとしているデータが見つかりません");
                }


                sql = "SELECT [title], [problem], [data], [answer], [level] FROM [problemList] WHERE [id] = @id;";
                cmd.CommandText = sql;
                cmd.Parameters.Add("id", System.Data.DbType.Int32);
                cmd.Parameters["id"].Value = id;
                cmd.Prepare();

                using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        tbTitle.Text = reader[0].ToString();
                        tbProblem.Text = reader[1].ToString();
                        rtbResult.Text = reader[2].ToString();
                        tbAnswer.Text = reader[3].ToString();
                        tbLevel.Text = reader[4].ToString();
                    }                    
                }
            }        
            
            
        }

        public bool isMatchData(string id, MatchCollection mc) {
            if (mc == null) { return false; }

            //DBからマッチ情報を取得する
            using (SQLiteCommand cmd = con.CreateCommand()) {
                string sql = "SELECT [type], [matchIndex], [matchLength] FROM [matchData] WHERE [problem_id] = @id ORDER BY [ROWID];";
                cmd.CommandText = sql;

                cmd.Parameters.Add("id", System.Data.DbType.Int32);
                cmd.Parameters["id"].Value = id;
                cmd.Prepare();

                List<int[]> rightData = new List<int[]>();
                using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        rightData.Add(new int[] { Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]) });
                    }
                }

                //正規表現にマッチした結果と比較する
                int count = 0;
                foreach (Match match in mc) {

                    count++;
                    int index = match.Groups[0].Index;
                    int length = match.Groups[0].Length;

                    //判定
                    if (rightData.Count < count) {
                        //DBの方がデータがすくない時間違い
                        return false;
                    } else if (rightData[count - 1][0] != ALL_MATCH || rightData[count - 1][1] != index || rightData[count - 1][2] != length) {
                        //データが一致しないので間違い
                        return false;
                    }

                    for (int i = 1; i < match.Groups.Count; i++) {
                        count++;
                        index = match.Groups[i].Index;
                        length = match.Groups[i].Length;

                        //判定
                        if (rightData.Count < count) {
                            //DBの方がデータがすくない時間違い
                            return false;
                        } else if (rightData[count - 1][0] != GROUP_MATCH || rightData[count - 1][1] != index || rightData[count - 1][2] != length) {
                            //データが一致しないので間違い
                            return false;
                        }
                    }
                }

                //DBにあるデータの方が多い時は、データが一致しないので間違い
                if (count < rightData.Count) { return false; }
            }

            return true;
        }

        public void SelectProblemList(string problemId, TextBox tbMessage, RichTextBox rtbResult, RichTextBox rtbProblem){
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        string sql = "";
                        
                        sql = "SELECT [problem], [data] FROM [problemList] WHERE [id] = @id;";
                        cmd.CommandText = sql;
                        
                        cmd.Parameters.Add("id", System.Data.DbType.Int32);
                        cmd.Parameters["id"].Value = problemId;
                        cmd.Prepare();

                        //色、太字解除しておく(自由入力モードで実行した後だと残る)
                        RichTextBoxColorReset(rtbResult);
                        RichTextBoxColorReset(rtbProblem);
                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                tbMessage.Text = (string)reader[0];
                                rtbResult.Text = (string)reader[1];
                                rtbProblem.Text = (string)reader[1];
                            }
                        }

                        sql = "SELECT [type], [matchIndex], [matchLength] FROM [matchData] WHERE [problem_id] = @problemId;";
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("problemId", System.Data.DbType.Int32);
                        cmd.Parameters["problemId"].Value = problemId;
                        cmd.Prepare();


                        int selectPos = rtbProblem.SelectionStart;
                        rtbProblem.Select(selectPos, 0);
                        RichTextBoxColorReset(rtbProblem);

                        tbMessage.Tag = "";
                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                
                                int index = Convert.ToInt32(reader[1]);
                                int length = Convert.ToInt32(reader[2]);
                                if (RegexpDB.ALL_MATCH == Convert.ToInt32(reader[0])) {
                                    //全体マッチ
                                    rtbProblem.Select(index, length);
                                    rtbProblem.SelectionBackColor = Color.FromArgb(58, 243, 47);
                                
                                } else if (RegexpDB.GROUP_MATCH == Convert.ToInt32(reader[0])) {
                                    //部分マッチ
                                    rtbProblem.Select(index, length);
                                    rtbProblem.SelectionFont = new Font(rtbProblem.SelectionFont, FontStyle.Bold);

                                } else {
                                    string className = this.GetType().FullName;
                                    string methodName = MethodBase.GetCurrentMethod().Name;
                                    string errorMessage = "[Class]：" + className + "\n" +
                                                          "[Method]：" + methodName + "\n" +
                                                          "typeの値が不正です";
                                    throw new RegexpPracticeException(errorMessage);

                                }
                            }
                        }

                        rtbProblem.SelectionStart = selectPos;
                        rtbProblem.Select(selectPos, 0);

                        tbMessage.Tag = problemId;
                    }
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public void SelectAnswerFromProblemList(string id, TextBox tbMessage) {
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        string sql = "SELECT [problem], [answer] FROM [problemList] WHERE [id] = @id;";
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("id", System.Data.DbType.Int32);
                        cmd.Parameters["id"].Value = id;
                        cmd.Prepare();

                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            if(reader.HasRows==false){
                                MessageBox.Show("問題に該当するデータ（答え）が取得できません");
                            }
                            while (reader.Read()) {
                                tbMessage.Text = (string)reader[0] + System.Environment.NewLine +
                                                 "■答え" + System.Environment.NewLine +
                                                 (string)reader[1];
                            }
                        }
                    }
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public void DeleteProblemList(string problemId) {
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        string sql = "DELETE FROM [problemList] WHERE [id] = @problemId;";
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("problemId", System.Data.DbType.Int32);
                        cmd.Parameters["problemId"].Value = problemId;

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        private void RichTextBoxColorReset(RichTextBox rtbProblem) {
            if (rtbProblem.Text == "") { return; }

            int selectPos = rtbProblem.SelectionStart;
            rtbProblem.SelectAll();
            rtbProblem.SelectionBackColor = Color.White;
            //ときおり、input.SelectionFontがnullを返しエラーとなるのでnullの時は何もしない
            if (rtbProblem.SelectionFont != null) {
                rtbProblem.SelectionFont = new Font(rtbProblem.SelectionFont, FontStyle.Regular);
            }
            rtbProblem.SelectionLength = 0;
            rtbProblem.SelectionStart = selectPos;
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
            dgvColumnSelect.Image = new Bitmap(Properties.Resources.dgv_select);
            dgvColumnSelect.ImageLayout = DataGridViewImageCellLayout.Normal;
            dgvProblemList.Columns.Add(dgvColumnSelect);
            dgvProblemList.Columns[dgvProblemList.Columns.Count - 1].Width = 50;


            dgvProblemList.DataSource = dataTable;
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT id, level AS [難易度], title AS [タイトル] FROM problemList ORDER BY [難易度]", con)) {
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

        public void UpdateRegexpProblem(string id, string title, string problem, string data, string answer, int level, MatchCollection matches) {
            using (SQLiteCommand cmd = con.CreateCommand()) {
                try {
                    //IDが存在するかチェック
                    string sql = "";
                    sql = "SELECT COUNT(*) FROM [problemList] WHERE [id] = @id;";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("id", System.Data.DbType.Int32);
                    cmd.Parameters["id"].Value = id;
                    cmd.Prepare();

                    if (Convert.ToInt32(cmd.ExecuteScalar()) != 1) {
                        throw new RegexpPracticeException("データベースに、編集しようとしているデータが見つかりません");
                    }


                    //ProblemListテーブルに追加
                    this.UpdateProblemListTable(cmd, id, title, problem, data, answer, level);

                    //matchDataを削除
                    sql = "DELETE FROM [matchData] WHERE [problem_id] = @id;";
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("id", System.Data.DbType.Int32);
                    cmd.Parameters["id"].Value = id;
                    cmd.ExecuteNonQuery();

                    //matchDataテーブルに追加
                    int problem_id = Convert.ToInt32(id);
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

                } catch (Exception ex) {
                    throw ex;
                }
            }
        }


        public void UpdateProblemListTable(SQLiteCommand cmd, string id, string title, string problem, string data, string answer, int level) {
            using (SQLiteTransaction trans = con.BeginTransaction()) {
                try {
                    string sql = "UPDATE [problemList] " +
                                 "SET [title] = @title, [problem] = @problem, [data] = @data, " +
                                     "[answer] = @answer, [level] = @level, [mtime] = @mtime " +
                                     "WHERE id = @id;";

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
                    cmd.Parameters.Add("mtime", System.Data.DbType.String);
                    cmd.Parameters["mtime"].Value = currentTime;

                    cmd.Parameters.Add("id", System.Data.DbType.Int32);
                    cmd.Parameters["id"].Value = id;

                    cmd.ExecuteNonQuery();

                    trans.Commit();

                } catch (Exception ex) {
                    throw ex;
                }
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
            try {
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

            } catch (Exception ex) {
                throw ex;
            }
        }

        public int last_insert_id(SQLiteCommand cmd, string tableName) {
            cmd.CommandText = "select last_insert_rowid();";
            string rowid = cmd.ExecuteScalar().ToString();
            return int.Parse(rowid);
        }

        public void Dispose() {
            con.Close();
        }
    }
}
