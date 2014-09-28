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
            MessageBox.Show("登録");
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
