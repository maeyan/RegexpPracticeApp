using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using RegexpPracticeApp.View;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace RegexpPracticeApp {
    public partial class RegexpPracticeApp : Form {
        RegexpForm regexpForm = null;

        public RegexpPracticeApp() {
            InitializeComponent();

            UserInitialize();
        }


        public void UserInitialize() {
            //デフォルトでアイコンがオンの物を記憶さておく
            vRegexpPracticeApp.SwitchIcon.ActivePictureBox = this.iconHome;

            vRegexpPracticeApp.Form.SetAnnotation(rtbAnnotation);

            //デフォルトの表示
            this.changeFreeMode();

            regexpForm = new RegexpForm(rtbResult, tbRegexp, tbReplace, ckIgnoreCase, ckMultiLine);

        }

        /// <summary>
        /// アイコンをクリックした際に切り替える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconChange_Click(object sender, EventArgs e) {
            PictureBox currentPictureBox = (PictureBox)sender;
            vRegexpPracticeApp.SwitchIcon.switchingIcon(currentPictureBox);

            switch(currentPictureBox.Name){
                case "iconHome":
                    this.changeFreeMode();
                    break;
                case "iconProblem":
                    this.changeProblemMode();
                    break;
                case "iconImport":
                    break;
                case "iconExport":
                    break;
                case "iconSettings":
                    break;
                default:
                    break;
            }
        }


        private void bt_MouseLeave(object sender, EventArgs e) {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(50, 165, 231);
        }

        private void bt_MouseEnter(object sender, EventArgs e) {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(255, 99, 204);
        }



        /// <summary>
        /// フリーモード
        /// </summary>
        public void changeFreeMode() {
            //Button
            this.btAnswer.Visible = false;

            //Label
            this.lbUser.Text = "■検索/置換対象文字列入力欄";
            this.lbSystem.Text = "";
            this.lbReplace.Visible = true;

            //LinkLabel
            this.lnkSelectProblem.Visible = false;

            //Panel
            this.pnlModeSelect.Visible = true;

            //RadioButton
            this.rbSearch.Checked = true;

            //RichTextBox
            this.rtbProblem.Text = "";
            this.rtbProblem.ReadOnly = false;
            this.rtbResult.ReadOnly = false;
            this.rtbResult.Text = "";
            this.rtbResult.Width = 554;            

            //TextBox
            this.tbMessage.Tag = "";
            this.tbMessage.Text = "自由入力モードです";
            this.tbMessage.Width = 554;
            this.tbRegexp.Focus();
            this.tbRegexp.Text = "";
            this.tbReplace.Text = "";
            this.tbReplace.Visible = true;
            
        }


        /// <summary>
        /// 出題モード
        /// </summary>
        public void changeProblemMode() {
            //Button
            this.btAnswer.Visible = true;

            //Label
            this.lbUser.Text = "■正規表現実行結果";
            this.lbSystem.Text = "■下記結果なる正規表現を書いてください";
            this.lbReplace.Visible = false;

            //LinkLabel
            this.lnkSelectProblem.Visible = true;

            //Panel
            this.pnlModeSelect.Visible = false;

            //RichTextBox
            //this.rtbProblem.Enabled = false;
            this.rtbProblem.Text = "";
            this.rtbProblem.ReadOnly = true;
            this.rtbProblem.ForeColor = Color.Black;
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Text = "";
            this.rtbResult.Width = 271;
            this.rtbResult.ForeColor = Color.Black;

            //TextBox
            this.tbMessage.Tag = "";
            this.tbMessage.Text = "問題を選択してください";
            this.tbMessage.Width = 504;
            this.tbRegexp.Text = "";
            this.tbReplace.Visible = false;
        }

        private void opReplace_CheckedChanged(object sender, EventArgs e) {
            this.tbReplace.Enabled = true;
            this.lbReplace.ForeColor = Color.Black;
        }

        private void opSearch_CheckedChanged(object sender, EventArgs e) {
            this.tbReplace.Enabled = false;
            this.lbReplace.ForeColor = Color.DarkGray;
        }

        private void RegexpPracticeApp_Activated(object sender, EventArgs e) {
            this.rtbResult.Focus();
        }

        private void iconChange_MouseEnter(object sender, EventArgs e) {
            PictureBox currentPictureBox = (PictureBox)sender;
            vRegexpPracticeApp.SwitchIcon.mouseEnterIcon(currentPictureBox);
        }

        private void iconChange_MouseLeave(object sender, EventArgs e) {
            PictureBox currentPictureBox = (PictureBox)sender;
            vRegexpPracticeApp.SwitchIcon.mouseLeaveIcon(currentPictureBox);
        }

        private void btExecute_Click(object sender, EventArgs e) {
            RexexpExecute();
        }

        private void RexexpExecute(){
            if(this.rbSearch.Checked){
                regexpForm.execMatch();
            
            }else if(this.rbReplace.Checked){
                regexpForm.execReplace();
            }

            //出題モードの時は、あってたかどうか判定する
            if (vRegexpPracticeApp.SwitchIcon.ActivePictureBox.Name == "iconProblem") {
                string id = (string)this.tbMessage.Tag;
                MatchCollection lastMatchData = regexpForm.lastMatchData;
                RegexpDB db = new RegexpDB();
                if (db.isMatchData(id, lastMatchData)) {
                    MessageBox.Show("正解");

                } else {
                    MessageBox.Show("不正解");
                }
            }
        }

        private void rtbResult_TextChanged(object sender, EventArgs e) {

            if (rtbResult.Focused) {
                regexpForm.execMatch();
            }

        }

        private void tbRegexp_TextChanged(object sender, EventArgs e) {
            regexpForm.RichTextBoxColorReset();
        }

        private void ckIgnoreCase_CheckedChanged(object sender, EventArgs e) {
            regexpForm.RichTextBoxColorReset();
        }

        private void ckMultiLine_CheckedChanged(object sender, EventArgs e) {
            regexpForm.RichTextBoxColorReset();
        }

        private void lnkSelectProblem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            vRegexpPracticeApp.Problem.ShowProblemPanel(this.pnlProblem, this.dgvProblemList);
        }


        private void lnkCloseProblemList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            vRegexpPracticeApp.Problem.CloseProblemPanel(this.pnlProblem);
        }

        private void lnkEntryProblem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            //編集画面を開く
            showEditForm();
        }

        private void showEditForm(string id = "") {
            try {
                ProblemEditForm form = new ProblemEditForm(id);
                form.StartPosition = FormStartPosition.Manual; //任意の位置に表示するため設定を変える
                form.Location = new Point(this.Location.X + 25, this.Location.Y + 25); //25ずつオフセットした位置に出す
                form.ShowDialog(this);
                form.Show();
                form.Dispose();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            vRegexpPracticeApp.Problem.ShowProblemPanel(this.pnlProblem, this.dgvProblemList);
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Test.db")) {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT [ROWID], [ユーザ名], [組織名] FROM Sample", con)) {
                    //using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT id, level, title FROM problemList", con)) {
                    adapter.Fill(dataTable);
                }
            }
        }

        private void dgvProblemList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;

            string id = dgv.CurrentRow.Cells[1].Value.ToString();

            if (dgv.Columns[e.ColumnIndex].Name == "選択") {
                RegexpDB db = new RegexpDB();
                try {
                    db.SelectProblemList(id, this.tbMessage, this.rtbResult, this.rtbProblem);
                    vRegexpPracticeApp.Problem.CloseProblemPanel(this.pnlProblem);
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            } else if (dgv.Columns[e.ColumnIndex].Name == "編集") {
                showEditForm(id);
            } else if (dgv.Columns[e.ColumnIndex].Name == "削除") {
                try {
                    RegexpDB db = new RegexpDB();
                    db.DeleteProblemList(id);         //削除
                    db.LoadTitleList(dgvProblemList); //更新
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void RegexpPracticeApp_Load(object sender, EventArgs e) {

        }

        private void btAnswer_Click(object sender, EventArgs e) {

            string id = (string)this.tbMessage.Tag;
            try {
                RegexpDB db = new RegexpDB();
                db.SelectAnswerFromProblemList(id, this.tbMessage);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void tbRegexp_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                RexexpExecute();
            }
        }
    }
}
