using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegexpPracticeApp.View;

namespace RegexpPracticeApp {
    public partial class ProblemEditForm : Form {
        RegexpForm regexpForm = null;
        string _id = "";

        public ProblemEditForm(string id) {
            InitializeComponent();
            _id = id;
            UserInitialize();
        }

        private void btExecute_Click(object sender, EventArgs e) {
            regexpForm.execMatch(false);
        }

        private void btRegistry_Click(object sender, EventArgs e) {

            if (!vProblemEditForm.Form.v_tbTitle(this.tbTitle)) { return; }
            if (!vProblemEditForm.Form.v_tbProblem(this.tbProblem)) { return; }
            if (!vProblemEditForm.Form.v_rtbResult(this.rtbResult)) { return; }
            if (!vProblemEditForm.Form.v_tbProblem(this.tbAnswer)) { return; }
            if (!vProblemEditForm.Form.v_tbLevel(this.tbLevel)) { return; }
            if (!regexpForm.isMatch()) {
                MessageBox.Show("マッチする正規表現を記入してください");
                return; 
            }

            RegexpDB db = new RegexpDB();
            try {
                if (_id == "") {
                    db.InsertRegexpProblem(this.tbTitle.Text,
                                           this.tbProblem.Text,
                                           this.rtbResult.Text,
                                           this.tbAnswer.Text,
                                           int.Parse(this.tbLevel.Text),
                                           regexpForm.lastMatchData);
                } else {
                    db.UpdateRegexpProblem(_id,
                                           this.tbTitle.Text,
                                           this.tbProblem.Text,
                                           this.rtbResult.Text,
                                           this.tbAnswer.Text,
                                           int.Parse(this.tbLevel.Text),
                                           regexpForm.lastMatchData);
                }


            } catch(Exception ex){
                MessageBox.Show(ex.Message);
                return;
            }

            this.Close();

        }

        private void ProblemEditForm_Activated(object sender, EventArgs e) {
            this.tbTitle.Focus();
        }

        public void UserInitialize() {
            
            //編集
            if (_id != "") { 
                lb_Title.Text = "編集画面";

                RegexpDB db = new RegexpDB();

                try {
                    db.LoadData(_id, this.tbTitle, this.tbProblem, this.rtbResult, this.tbAnswer, this.tbLevel);
                } catch (Exception ex) {
                    this.Close();
                    throw ex;
                }
            
            }

            regexpForm = new RegexpForm(rtbResult, tbRegexp, ckIgnoreCase, ckMultiLine);

            vRegexpPracticeApp.Form.SetAnnotationProblem(rtbAnnotation);
        }

        private void rtbResult_TextChanged(object sender, EventArgs e) {
            if (this.rtbResult.Focused) { regexpForm.execMatch(true); }
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

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bt_MouseLeave(object sender, EventArgs e) {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(50, 165, 231);
        }

        private void bt_MouseEnter(object sender, EventArgs e) {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(255, 99, 204);
        }

        private void tbRegexp_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                regexpForm.execMatch(false);
            }
        }
    }
}
