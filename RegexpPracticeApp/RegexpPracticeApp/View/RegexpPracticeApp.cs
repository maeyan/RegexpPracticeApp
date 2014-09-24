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

        private void RegexpPracticeAPp_Load(object sender, EventArgs e) {

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

            //Panel
            this.pnlModeSelect.Visible = true;

            //RadioButton
            this.rbSearch.Checked = true;

            //RichTextBox
            this.rtbProblem.Enabled = true;
            this.rtbProblem.Text = "";
            this.rtbProblem.ReadOnly = false;
            this.rtbResult.Enabled = true;
            this.rtbResult.ReadOnly = false;
            this.rtbResult.Text = "";
            this.rtbResult.Width = 554;            

            //TextBox
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

            //Panel
            this.pnlModeSelect.Visible = false;

            //RichTextBox
            this.rtbProblem.Enabled = false;
            this.rtbProblem.Text = "";
            this.rtbProblem.ReadOnly = true;
            this.rtbResult.Enabled = false;
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Text = "";
            this.rtbResult.Width = 271;

            //TextBox
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
            if(this.rbSearch.Checked){
                regexpForm.execMatch();
            
            }else if(this.rbReplace.Checked){
                regexpForm.execReplace();
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
    }
}
