using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegexpPracticeApp.View {
    class vProblemEditForm {
        public class Form {

            public static bool v_tbTitle(TextBox tbTitle) {

                bool ret = true;
                
                //空欄またはDBで定められている文字数を超えたらエラー
                if (tbTitle.Text == "") {
                    ret = false;
                } else if (50 < tbTitle.Text.Length) {
                    ret = false;
                }

                if (!ret) { MessageBox.Show("タイトル欄は、1文字以上50文字以下の文字列を入力してください"); }
                return ret;
            }

            public static bool v_tbProblem(TextBox tbProblem) {

                bool ret = true;
                
                //空欄またはDBで定められている文字数を超えたらエラー
                if (tbProblem.Text == "") {
                    ret = false;
                } else if (500 < tbProblem.Text.Length) {
                    ret = false;
                }

                if (!ret) { MessageBox.Show("問題欄は、1文字以上500文字以下の文字列を入力してください"); }
                return ret;
            }

            public static bool v_rtbResult(RichTextBox rtbResult) {

                bool ret = true;

                //空欄またはDBで定められている文字数を超えたらエラー
                if (rtbResult.Text == "") {
                    ret = false;
                } else if (500 < rtbResult.Text.Length) {
                    ret = false;
                }

                if (!ret) { MessageBox.Show("データ/実行結果欄は、1文字以上500文字以下の文字列を入力してください"); }
                return ret;
            }

            public static bool v_tbAnswer(TextBox tbAnswer) {

                bool ret = true;

                //空欄またはDBで定められている文字数を超えたらエラー
                if (tbAnswer.Text == "") {
                    ret = false;
                } else if (500 < tbAnswer.Text.Length) {
                    ret = false;
                }

                if (!ret) { MessageBox.Show("答え欄は、1文字以上500文字以下の文字列を入力してください"); }
                return ret;
            }


            public static bool v_tbLevel(TextBox tbLevel) {

                bool ret = true;
                
                //空欄またはDBで定められている文字数を超えたらエラー
                if (tbLevel.Text == "") {
                    ret = false;
                } else {
                    try {
                        int value = int.Parse(tbLevel.Text);
                        if (value < 1 || 999 < value) { ret = false; }
                    }catch{
                        ret = false;
                    } finally {
                    }
                }

                if (!ret) { MessageBox.Show("難易度欄は、1～999の数字を入力してください"); }
                return ret;
            }
        }
    }
}
