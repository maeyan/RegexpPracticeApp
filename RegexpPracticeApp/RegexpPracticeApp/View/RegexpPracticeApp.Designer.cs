namespace RegexpPracticeApp {
    partial class RegexpPracticeAPp {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.iconProblem = new System.Windows.Forms.PictureBox();
            this.iconSettings = new System.Windows.Forms.PictureBox();
            this.iconImport = new System.Windows.Forms.PictureBox();
            this.iconExport = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.iconHome);
            this.panel1.Controls.Add(this.iconProblem);
            this.panel1.Controls.Add(this.iconSettings);
            this.panel1.Controls.Add(this.iconImport);
            this.panel1.Controls.Add(this.iconExport);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 463);
            this.panel1.TabIndex = 0;
            // 
            // iconHome
            // 
            this.iconHome.Image = global::RegexpPracticeApp.Properties.Resources.on_home;
            this.iconHome.Location = new System.Drawing.Point(12, 12);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(37, 37);
            this.iconHome.TabIndex = 6;
            this.iconHome.TabStop = false;
            this.iconHome.Tag = "home";
            this.toolTip1.SetToolTip(this.iconHome, "問題");
            this.iconHome.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // iconProblem
            // 
            this.iconProblem.Image = global::RegexpPracticeApp.Properties.Resources.off_problem;
            this.iconProblem.Location = new System.Drawing.Point(12, 62);
            this.iconProblem.Name = "iconProblem";
            this.iconProblem.Size = new System.Drawing.Size(37, 37);
            this.iconProblem.TabIndex = 5;
            this.iconProblem.TabStop = false;
            this.iconProblem.Tag = "problem";
            this.toolTip1.SetToolTip(this.iconProblem, "問題の一覧を表示");
            this.iconProblem.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // iconSettings
            // 
            this.iconSettings.Image = global::RegexpPracticeApp.Properties.Resources.off_settings;
            this.iconSettings.Location = new System.Drawing.Point(12, 212);
            this.iconSettings.Name = "iconSettings";
            this.iconSettings.Size = new System.Drawing.Size(37, 37);
            this.iconSettings.TabIndex = 4;
            this.iconSettings.TabStop = false;
            this.iconSettings.Tag = "settings";
            this.toolTip1.SetToolTip(this.iconSettings, "設定");
            this.iconSettings.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // iconImport
            // 
            this.iconImport.Image = global::RegexpPracticeApp.Properties.Resources.off_import;
            this.iconImport.Location = new System.Drawing.Point(12, 112);
            this.iconImport.Name = "iconImport";
            this.iconImport.Size = new System.Drawing.Size(37, 37);
            this.iconImport.TabIndex = 3;
            this.iconImport.TabStop = false;
            this.iconImport.Tag = "import";
            this.toolTip1.SetToolTip(this.iconImport, "問題をImportする");
            this.iconImport.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // iconExport
            // 
            this.iconExport.Image = global::RegexpPracticeApp.Properties.Resources.off_export;
            this.iconExport.Location = new System.Drawing.Point(12, 162);
            this.iconExport.Name = "iconExport";
            this.iconExport.Size = new System.Drawing.Size(37, 37);
            this.iconExport.TabIndex = 2;
            this.iconExport.TabStop = false;
            this.iconExport.Tag = "export";
            this.toolTip1.SetToolTip(this.iconExport, "問題をExportする");
            this.iconExport.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(556, 76);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "問題を選択してください";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(351, 112);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 252);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.Location = new System.Drawing.Point(66, 112);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(271, 252);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(141, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(423, 25);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "正規表現";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(570, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "■以下になる正規表現を書いてください";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "■実行結果";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(284, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "※正規表現全体に一致⇒緑背景色／カッコに一致⇒緑背景色＋太字";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(141, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 26);
            this.panel3.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(141, 425);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(423, 25);
            this.textBox3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "置換文字列";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "検索";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "置換";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RegexpPracticeAPp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "RegexpPracticeAPp";
            this.Text = "Regur Express Siren!";
            this.Load += new System.EventHandler(this.RegexpPracticeAPp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconImport;
        private System.Windows.Forms.PictureBox iconExport;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconProblem;
        private System.Windows.Forms.PictureBox iconSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}

