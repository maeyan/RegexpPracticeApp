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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.iconProblem = new System.Windows.Forms.PictureBox();
            this.iconSettings = new System.Windows.Forms.PictureBox();
            this.iconImport = new System.Windows.Forms.PictureBox();
            this.iconExport = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.iconHome);
            this.panel1.Controls.Add(this.iconProblem);
            this.panel1.Controls.Add(this.iconSettings);
            this.panel1.Controls.Add(this.iconImport);
            this.panel1.Controls.Add(this.iconExport);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 386);
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
            this.iconExport.Click += new System.EventHandler(this.iconChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(126, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(300, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 260);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // RegexpPracticeAPp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(668, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegexpPracticeAPp";
            this.Text = "Regur Express Siren!";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iconImport;
        private System.Windows.Forms.PictureBox iconExport;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconProblem;
        private System.Windows.Forms.PictureBox iconSettings;
    }
}

