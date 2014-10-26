using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace RegexpPracticeApp {
    class RegexpForm {
        public static Color BG_PINK = Color.FromArgb(255, 182, 193);
        public static Color BG_BLUE = Color.FromArgb(173, 216, 230);

        private CheckBox _ckIgnoreCase = null;
        private CheckBox _ckMultiLine = null;
        private RichTextBox _rtbInputString = null;
        private TextBox _tbRegexp = null;
        private TextBox _tbReplace = null;
        private MatchCollection _lastMatchData = null;

        public MatchCollection lastMatchData {
            get { return _lastMatchData; }
        }

        public RegexpForm(RichTextBox rtbInputString,
                          TextBox tbRegexp, TextBox tbReplace,
                          CheckBox ckIgnoreCase, CheckBox ckMultiLine) {
            _rtbInputString = rtbInputString;
            _tbRegexp = tbRegexp;
            _tbReplace = tbReplace;
            _ckIgnoreCase = ckIgnoreCase;
            _ckMultiLine = ckMultiLine;
        }

        public RegexpForm(RichTextBox rtbInputString,
                          TextBox tbRegexp, CheckBox ckIgnoreCase, CheckBox ckMultiLine) {
            _rtbInputString = rtbInputString;
            _tbRegexp = tbRegexp;
            _ckIgnoreCase = ckIgnoreCase;
            _ckMultiLine = ckMultiLine;
        }


        public void RichTextBoxColorReset() {
            if (_rtbInputString.Text == "") { return; }

            int selectPos = _rtbInputString.SelectionStart;
            _rtbInputString.SelectAll();
            _rtbInputString.SelectionBackColor = Color.White;
            //ときおり、input.SelectionFontがnullを返しエラーとなるのでnullの時は何もしない
            if (_rtbInputString.SelectionFont != null) {
                _rtbInputString.SelectionFont = new Font(_rtbInputString.SelectionFont, FontStyle.Regular);
            }

            _rtbInputString.SelectionLength = 0;
            _rtbInputString.SelectionStart = selectPos;
        }

        public void execMatch(bool GroupMatchFlag) {
            
            RichTextBoxColorReset();

            //初期化
            _lastMatchData = null;

            //textbox or 正規表現が空文字の時何もせず終了とする
            if (_rtbInputString.Text == "" || _tbRegexp.Text == "") { return; }

            int selectPos = _rtbInputString.SelectionStart;
            _rtbInputString.Select(selectPos, 0);

            try {
                Color CurrentColor = BG_BLUE;
                _lastMatchData = Regex.Matches(_rtbInputString.Text, _tbRegexp.Text, this.getOption());
                foreach (Match match in _lastMatchData) {
                    //全体マッチ
                    _rtbInputString.Select(match.Groups[0].Index, match.Groups[0].Length);
                    if (CurrentColor == BG_PINK) {
                        _rtbInputString.SelectionBackColor = BG_BLUE;
                        CurrentColor = BG_BLUE;
                    } else {
                        _rtbInputString.SelectionBackColor = BG_PINK;
                        CurrentColor = BG_PINK;
                    }

                    if (GroupMatchFlag) {
                        for (int i = 1; i < match.Groups.Count; i++) {
                            //部分マッチ
                            _rtbInputString.Select(match.Groups[i].Index, match.Groups[i].Length);
                            _rtbInputString.SelectionFont = new Font(_rtbInputString.SelectionFont, FontStyle.Underline);
                        }
                    }
                }
            }catch{
            } finally {
                _rtbInputString.SelectionStart = selectPos;
                _rtbInputString.Select(selectPos, 0);
            }
         

        }

        public void execReplace() {
            RichTextBoxColorReset();

            //textbox or 正規表現が空文字の時何もせず終了とする
            if (_rtbInputString.Text == "" || _tbRegexp.Text == "") { return; }

            try {
                _rtbInputString.Text = Regex.Replace(_rtbInputString.Text, _tbRegexp.Text, _tbReplace.Text, getOption());
            } catch {
            }
        }

        private RegexOptions getOption(){

            RegexOptions options = RegexOptions.None;

            if (_ckIgnoreCase.Checked && !_ckMultiLine.Checked) {
                options = RegexOptions.IgnoreCase;
            } else if (!_ckIgnoreCase.Checked && _ckMultiLine.Checked) {
                options = RegexOptions.Multiline;
            } else if (_ckIgnoreCase.Checked && _ckMultiLine.Checked) {
                options = RegexOptions.IgnoreCase | RegexOptions.Multiline;
            }

            return options;
        }

        public bool isMatch() {
            bool ret = false;
            try {
                _lastMatchData = Regex.Matches(_rtbInputString.Text, _tbRegexp.Text, this.getOption());
                foreach (Match match in _lastMatchData) {
                    //全体マッチ
                    int index = match.Groups[0].Index;
                    int length = match.Groups[0].Length;

                    _rtbInputString.SelectionBackColor = Color.FromArgb(58, 243, 47);

                    for (int i = 1; i < match.Groups.Count; i++) {
                        //部分マッチ
                        _rtbInputString.Select(match.Groups[i].Index, match.Groups[i].Length);
                        _rtbInputString.SelectionFont = new Font(_rtbInputString.SelectionFont, FontStyle.Underline);
                    }
                    ret = true;
                }                
            } catch {
                ret = false;
            } 
            return ret;
        }
    }
}
