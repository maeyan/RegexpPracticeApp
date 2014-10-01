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

        public ProblemEditForm() {
            InitializeComponent();

            UserInitialize();
        }

        private void btExecute_Click(object sender, EventArgs e) {
            regexpForm.execMatch();
        }

        private void btRegistry_Click(object sender, EventArgs e) {

            if (!vProblemEditForm.Form.v_tbTitle(this.tbTitle)) { return; }
            if (!vProblemEditForm.Form.v_tbProblem(this.tbProblem)) { return; }
            if (!vProblemEditForm.Form.v_rtbResult(this.rtbResult)) { return; }
            if (!vProblemEditForm.Form.v_tbProblem(this.tbAnswer)) { return; }
            if (!vProblemEditForm.Form.v_tbLevel(this.tbLevel)) { return; }
            if (!regexpForm.isMatch()) { return; }

            RegexpDB db = new RegexpDB();
            db.InsertRegexpProblem(this.tbTitle.Text, 
                                   this.tbProblem.Text, 
                                   this.rtbResult.Text, 
                                   this.tbAnswer.Text, 
                                   int.Parse(this.tbLevel.Text),
                                   regexpForm.lastMatchData);

        }

        private void ProblemEditForm_Activated(object sender, EventArgs e) {
            this.tbTitle.Focus();
        }

        public void UserInitialize() {

            regexpForm = new RegexpForm(rtbResult, tbRegexp, ckIgnoreCase, ckMultiLine);

            vRegexpPracticeApp.Form.SetAnnotation(rtbAnnotation);
        }

        private void rtbResult_TextChanged(object sender, EventArgs e) {
            if (this.rtbResult.Focused) { regexpForm.execMatch(); }
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
    }
}
