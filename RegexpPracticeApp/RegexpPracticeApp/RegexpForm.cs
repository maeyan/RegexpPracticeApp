﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace RegexpPracticeApp {
    class RegexpForm {
        private CheckBox _ckIgnoreCase = null;
        private CheckBox _ckMultiLine = null;
        private RichTextBox _rtbInputString = null;
        private TextBox _tbRegexp = null;
        private TextBox _tbReplace = null;


        public RegexpForm(RichTextBox rtbInputString, 
                          TextBox tbRegexp, TextBox tbReplace, 
                          CheckBox ckIgnoreCase, CheckBox ckMultiLine) {
            _rtbInputString = rtbInputString;
            _tbRegexp = tbRegexp;
            _tbReplace = tbReplace;
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
            _rtbInputString.SelectionStart = selectPos;
        }

        public void execMatch() {
            
            RichTextBoxColorReset();

            //textbox or 正規表現が空文字の時何もせず終了とする
            if (_rtbInputString.Text == "" || _tbRegexp.Text == "") { return; }

            int selectPos = _rtbInputString.SelectionStart;
            _rtbInputString.Select(selectPos, 0);

            try {
                foreach (Match match in Regex.Matches(_rtbInputString.Text, _tbRegexp.Text, this.getOption())) {
                    //全体マッチ
                    _rtbInputString.Select(match.Groups[0].Index, match.Groups[0].Length);
                    _rtbInputString.SelectionBackColor = Color.FromArgb(58, 243, 47);

                    for (int i = 1; i < match.Groups.Count; i++) {
                        //部分マッチ
                        _rtbInputString.Select(match.Groups[i].Index, match.Groups[i].Length);
                        _rtbInputString.SelectionFont = new Font(_rtbInputString.SelectionFont, FontStyle.Bold);
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
    }
}