using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Data.SQLite;

namespace RegexpPracticeApp.View{
    class vRegexpPracticeApp {
        public class SwitchIcon {

            static private PictureBox _ActivePictureBox = null;

            static public PictureBox ActivePictureBox {
                get { return _ActivePictureBox; }
                set { _ActivePictureBox = value; }
            }

            static public void mouseLeaveIcon(PictureBox CurrentIcon) {
                if (_ActivePictureBox == CurrentIcon) { return; }
                string resourceName = CurrentIcon.Tag.ToString();

                Assembly assy = Assembly.GetEntryAssembly();
                ResourceManager rm = new ResourceManager("RegexpPracticeApp.Properties.Resources", assy);

                //現在、ActiveなアイコンMouseEnter用の画像に差し替える
                Image image = (Image)rm.GetObject("off_" + resourceName);
                CurrentIcon.Image = image;
                Application.DoEvents();
            }

            static public void mouseEnterIcon(PictureBox CurrentIcon) {
                if (_ActivePictureBox == CurrentIcon) { return; }
                string resourceName = CurrentIcon.Tag.ToString();

                Assembly assy = Assembly.GetEntryAssembly();
                ResourceManager rm = new ResourceManager("RegexpPracticeApp.Properties.Resources", assy);

                //現在、ActiveなアイコンMouseEnter用の画像に差し替える
                Image image = (Image)rm.GetObject("hover_" + resourceName);
                CurrentIcon.Image = image;
                Application.DoEvents();
            }

            static public void switchingIcon(PictureBox CurrentIcon) {

                if (_ActivePictureBox == CurrentIcon) { return; }
                string resourceName = _ActivePictureBox.Tag.ToString();

                Assembly assy = Assembly.GetEntryAssembly();
                ResourceManager rm = new ResourceManager("RegexpPracticeApp.Properties.Resources", assy);

                //現在、Activeなアイコンをオフにする
                Image image = (Image)rm.GetObject("off_" + resourceName);
                _ActivePictureBox.Image = image;
                Application.DoEvents();

                //クリックされたアイコンをオンにする
                resourceName = CurrentIcon.Tag.ToString();
                image = (Image)rm.GetObject("on_" + resourceName);
                CurrentIcon.Image = image;

                //アクティブなアイコンを差し替える
                SwitchIcon.ActivePictureBox = CurrentIcon;

                Application.DoEvents();
            }
        }

        public class Form {
            static public void SetAnnotation(RichTextBox annotation) {
                annotation.Select(11, 4);
                annotation.SelectionBackColor = Color.FromArgb(58, 243, 47);
                annotation.Select(23, 7);
                annotation.SelectionBackColor = Color.FromArgb(58, 243, 47);
                annotation.SelectionFont = new Font(annotation.SelectionFont, FontStyle.Bold);
            }
        }

        public class Problem {

            static public void ShowProblemPanel(Panel pnl, DataGridView dgvProblemList) {
                          

                //DataBaseからデータを読み込む
                RegexpDB db = new RegexpDB();
                db.LoadTitleList(dgvProblemList);

                while (60 < pnl.Left) { //65 or
                    pnl.Left -= 10;
                    Application.DoEvents();
                }

            }

            static public void CloseProblemPanel(Panel pnl) {

                while (pnl.Left<650) {
                    pnl.Left += 10;
                    Application.DoEvents();
                }

            }
        }
    }
}
