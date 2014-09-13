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
    public partial class RegexpPracticeAPp : Form {
        PictureBox ActivePictureBox = null;

        public RegexpPracticeAPp() {
            InitializeComponent();
            ActivePictureBox = this.iconHome;
        }

        private void iconChange_Click(object sender, EventArgs e) {
            PictureBox currentPictureBox = (PictureBox)sender;
            ViewRPA.switchingIcon(ActivePictureBox, currentPictureBox);
            ActivePictureBox = currentPictureBox; 
        }
    }
}
