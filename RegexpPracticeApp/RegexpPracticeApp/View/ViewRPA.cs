using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

namespace RegexpPracticeApp.View{
    class ViewRPA {
        public static void switchingIcon(PictureBox ActiveIcon, PictureBox CurrentIcon) {
            
            string resourceName = ActiveIcon.Tag.ToString();

            Assembly assy = Assembly.GetEntryAssembly();
            ResourceManager rm = new ResourceManager("RegexpPracticeApp.Properties.Resources", assy);

            //現在、Activeなアイコンをオフにする
            Image image = (Image)rm.GetObject("off_" + resourceName);
            ActiveIcon.Image = image;
            Application.DoEvents();

            //クリックされたアイコンをオンにする
            resourceName = CurrentIcon.Tag.ToString();
            image = (Image)rm.GetObject("on_" + resourceName);
            CurrentIcon.Image = image;
            Application.DoEvents();
        }
    }
}
