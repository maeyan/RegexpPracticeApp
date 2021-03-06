﻿namespace RegexpPracticeApp {
    partial class RegexpPracticeApp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexpPracticeApp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.iconProblem = new System.Windows.Forms.PictureBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.rtbProblem = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tbRegexp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRegexp = new System.Windows.Forms.Label();
            this.btExecute = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSystem = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnkCloseProblemList = new System.Windows.Forms.LinkLabel();
            this.pnlModeSelect = new System.Windows.Forms.Panel();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbSearch = new System.Windows.Forms.RadioButton();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.lbReplace = new System.Windows.Forms.Label();
            this.btAnswer = new System.Windows.Forms.Button();
            this.rtbAnnotation = new System.Windows.Forms.RichTextBox();
            this.ckIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckMultiLine = new System.Windows.Forms.CheckBox();
            this.pnlProblem = new System.Windows.Forms.Panel();
            this.lnkEntryProblem = new System.Windows.Forms.LinkLabel();
            this.dgvProblemList = new System.Windows.Forms.DataGridView();
            this.lnkSelectProblem = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).BeginInit();
            this.pnlModeSelect.SuspendLayout();
            this.pnlProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.iconHome);
            this.panel1.Controls.Add(this.iconProblem);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 488);
            this.panel1.TabIndex = 0;
            // 
            // iconHome
            // 
            this.iconHome.Image = ((System.Drawing.Image)(resources.GetObject("iconHome.Image")));
            this.iconHome.Location = new System.Drawing.Point(12, 12);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(37, 37);
            this.iconHome.TabIndex = 6;
            this.iconHome.TabStop = false;
            this.iconHome.Tag = "home";
            this.toolTip1.SetToolTip(this.iconHome, "問題");
            this.iconHome.Click += new System.EventHandler(this.iconChange_Click);
            this.iconHome.MouseEnter += new System.EventHandler(this.iconChange_MouseEnter);
            this.iconHome.MouseLeave += new System.EventHandler(this.iconChange_MouseLeave);
            // 
            // iconProblem
            // 
            this.iconProblem.Image = ((System.Drawing.Image)(resources.GetObject("iconProblem.Image")));
            this.iconProblem.Location = new System.Drawing.Point(12, 62);
            this.iconProblem.Name = "iconProblem";
            this.iconProblem.Size = new System.Drawing.Size(37, 37);
            this.iconProblem.TabIndex = 5;
            this.iconProblem.TabStop = false;
            this.iconProblem.Tag = "problem";
            this.toolTip1.SetToolTip(this.iconProblem, "問題の一覧を表示");
            this.iconProblem.Click += new System.EventHandler(this.iconChange_Click);
            this.iconProblem.MouseEnter += new System.EventHandler(this.iconChange_MouseEnter);
            this.iconProblem.MouseLeave += new System.EventHandler(this.iconChange_MouseLeave);
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.Location = new System.Drawing.Point(72, 28);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(504, 65);
            this.tbMessage.TabIndex = 2;
            // 
            // rtbProblem
            // 
            this.rtbProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbProblem.ForeColor = System.Drawing.Color.DarkGray;
            this.rtbProblem.Location = new System.Drawing.Point(357, 117);
            this.rtbProblem.Name = "rtbProblem";
            this.rtbProblem.Size = new System.Drawing.Size(271, 235);
            this.rtbProblem.TabIndex = 4;
            this.rtbProblem.Text = "";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbResult.Location = new System.Drawing.Point(72, 117);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(271, 235);
            this.rtbResult.TabIndex = 5;
            this.rtbResult.Text = "";
            this.rtbResult.TextChanged += new System.EventHandler(this.rtbResult_TextChanged);
            // 
            // tbRegexp
            // 
            this.tbRegexp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRegexp.Location = new System.Drawing.Point(141, 418);
            this.tbRegexp.Name = "tbRegexp";
            this.tbRegexp.Size = new System.Drawing.Size(423, 25);
            this.tbRegexp.TabIndex = 6;
            this.tbRegexp.TextChanged += new System.EventHandler(this.tbRegexp_TextChanged);
            this.tbRegexp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRegexp_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 8;
            // 
            // lbRegexp
            // 
            this.lbRegexp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRegexp.AutoSize = true;
            this.lbRegexp.Location = new System.Drawing.Point(67, 421);
            this.lbRegexp.Name = "lbRegexp";
            this.lbRegexp.Size = new System.Drawing.Size(56, 18);
            this.lbRegexp.TabIndex = 9;
            this.lbRegexp.Text = "正規表現";
            // 
            // btExecute
            // 
            this.btExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExecute.ForeColor = System.Drawing.Color.White;
            this.btExecute.Location = new System.Drawing.Point(570, 418);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(53, 53);
            this.btExecute.TabIndex = 10;
            this.btExecute.Text = "実行";
            this.btExecute.UseVisualStyleBackColor = false;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            this.btExecute.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.btExecute.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(72, 96);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(20, 18);
            this.lbUser.TabIndex = 11;
            this.lbUser.Text = "■";
            // 
            // lbSystem
            // 
            this.lbSystem.AutoSize = true;
            this.lbSystem.Location = new System.Drawing.Point(354, 96);
            this.lbSystem.Name = "lbSystem";
            this.lbSystem.Size = new System.Drawing.Size(20, 18);
            this.lbSystem.TabIndex = 12;
            this.lbSystem.Text = "■";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // lnkCloseProblemList
            // 
            this.lnkCloseProblemList.AutoSize = true;
            this.lnkCloseProblemList.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lnkCloseProblemList.LinkColor = System.Drawing.Color.White;
            this.lnkCloseProblemList.Location = new System.Drawing.Point(8, -1);
            this.lnkCloseProblemList.Name = "lnkCloseProblemList";
            this.lnkCloseProblemList.Size = new System.Drawing.Size(28, 28);
            this.lnkCloseProblemList.TabIndex = 2;
            this.lnkCloseProblemList.TabStop = true;
            this.lnkCloseProblemList.Text = "✖";
            this.toolTip1.SetToolTip(this.lnkCloseProblemList, "閉じる");
            this.lnkCloseProblemList.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkCloseProblemList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCloseProblemList_LinkClicked);
            // 
            // pnlModeSelect
            // 
            this.pnlModeSelect.Controls.Add(this.rbReplace);
            this.pnlModeSelect.Controls.Add(this.rbSearch);
            this.pnlModeSelect.Location = new System.Drawing.Point(141, 358);
            this.pnlModeSelect.Name = "pnlModeSelect";
            this.pnlModeSelect.Size = new System.Drawing.Size(119, 26);
            this.pnlModeSelect.TabIndex = 14;
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(59, 3);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(50, 22);
            this.rbReplace.TabIndex = 1;
            this.rbReplace.TabStop = true;
            this.rbReplace.Text = "置換";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.opReplace_CheckedChanged);
            // 
            // rbSearch
            // 
            this.rbSearch.AutoSize = true;
            this.rbSearch.Checked = true;
            this.rbSearch.Location = new System.Drawing.Point(3, 3);
            this.rbSearch.Name = "rbSearch";
            this.rbSearch.Size = new System.Drawing.Size(50, 22);
            this.rbSearch.TabIndex = 0;
            this.rbSearch.TabStop = true;
            this.rbSearch.Text = "検索";
            this.rbSearch.UseVisualStyleBackColor = true;
            this.rbSearch.CheckedChanged += new System.EventHandler(this.opSearch_CheckedChanged);
            // 
            // tbReplace
            // 
            this.tbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbReplace.Enabled = false;
            this.tbReplace.Location = new System.Drawing.Point(141, 450);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(423, 25);
            this.tbReplace.TabIndex = 15;
            // 
            // lbReplace
            // 
            this.lbReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbReplace.AutoSize = true;
            this.lbReplace.ForeColor = System.Drawing.Color.DarkGray;
            this.lbReplace.Location = new System.Drawing.Point(67, 453);
            this.lbReplace.Name = "lbReplace";
            this.lbReplace.Size = new System.Drawing.Size(68, 18);
            this.lbReplace.TabIndex = 16;
            this.lbReplace.Text = "置換文字列";
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnswer.ForeColor = System.Drawing.Color.White;
            this.btAnswer.Location = new System.Drawing.Point(576, 28);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(50, 65);
            this.btAnswer.TabIndex = 17;
            this.btAnswer.Text = "答え";
            this.btAnswer.UseVisualStyleBackColor = false;
            this.btAnswer.Click += new System.EventHandler(this.btAnswer_Click);
            this.btAnswer.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.btAnswer.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // rtbAnnotation
            // 
            this.rtbAnnotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbAnnotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rtbAnnotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAnnotation.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rtbAnnotation.Location = new System.Drawing.Point(357, 361);
            this.rtbAnnotation.Name = "rtbAnnotation";
            this.rtbAnnotation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbAnnotation.Size = new System.Drawing.Size(265, 51);
            this.rtbAnnotation.TabIndex = 18;
            this.rtbAnnotation.Text = ".";
            // 
            // ckIgnoreCase
            // 
            this.ckIgnoreCase.AutoSize = true;
            this.ckIgnoreCase.Location = new System.Drawing.Point(141, 390);
            this.ckIgnoreCase.Name = "ckIgnoreCase";
            this.ckIgnoreCase.Size = new System.Drawing.Size(93, 22);
            this.ckIgnoreCase.TabIndex = 19;
            this.ckIgnoreCase.Text = "IgnoreCase";
            this.ckIgnoreCase.UseVisualStyleBackColor = true;
            this.ckIgnoreCase.CheckedChanged += new System.EventHandler(this.ckIgnoreCase_CheckedChanged);
            // 
            // ckMultiLine
            // 
            this.ckMultiLine.AutoSize = true;
            this.ckMultiLine.Location = new System.Drawing.Point(240, 390);
            this.ckMultiLine.Name = "ckMultiLine";
            this.ckMultiLine.Size = new System.Drawing.Size(79, 22);
            this.ckMultiLine.TabIndex = 20;
            this.ckMultiLine.Text = "MultiLine";
            this.ckMultiLine.UseVisualStyleBackColor = true;
            this.ckMultiLine.CheckedChanged += new System.EventHandler(this.ckMultiLine_CheckedChanged);
            // 
            // pnlProblem
            // 
            this.pnlProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlProblem.Controls.Add(this.lnkCloseProblemList);
            this.pnlProblem.Controls.Add(this.lnkEntryProblem);
            this.pnlProblem.Controls.Add(this.dgvProblemList);
            this.pnlProblem.Location = new System.Drawing.Point(650, 0);
            this.pnlProblem.Name = "pnlProblem";
            this.pnlProblem.Size = new System.Drawing.Size(650, 488);
            this.pnlProblem.TabIndex = 21;
            // 
            // lnkEntryProblem
            // 
            this.lnkEntryProblem.AutoSize = true;
            this.lnkEntryProblem.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lnkEntryProblem.LinkColor = System.Drawing.Color.White;
            this.lnkEntryProblem.Location = new System.Drawing.Point(463, 5);
            this.lnkEntryProblem.Name = "lnkEntryProblem";
            this.lnkEntryProblem.Size = new System.Drawing.Size(61, 20);
            this.lnkEntryProblem.TabIndex = 1;
            this.lnkEntryProblem.TabStop = true;
            this.lnkEntryProblem.Text = "新規登録";
            this.lnkEntryProblem.VisitedLinkColor = System.Drawing.Color.White;
            this.lnkEntryProblem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEntryProblem_LinkClicked);
            // 
            // dgvProblemList
            // 
            this.dgvProblemList.AllowUserToAddRows = false;
            this.dgvProblemList.AllowUserToDeleteRows = false;
            this.dgvProblemList.AllowUserToResizeColumns = false;
            this.dgvProblemList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.dgvProblemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProblemList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProblemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemList.Location = new System.Drawing.Point(49, 28);
            this.dgvProblemList.MultiSelect = false;
            this.dgvProblemList.Name = "dgvProblemList";
            this.dgvProblemList.ReadOnly = true;
            this.dgvProblemList.RowHeadersVisible = false;
            this.dgvProblemList.RowTemplate.Height = 21;
            this.dgvProblemList.Size = new System.Drawing.Size(475, 432);
            this.dgvProblemList.TabIndex = 0;
            this.dgvProblemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblemList_CellContentClick);
            // 
            // lnkSelectProblem
            // 
            this.lnkSelectProblem.AutoSize = true;
            this.lnkSelectProblem.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.lnkSelectProblem.Location = new System.Drawing.Point(69, 2);
            this.lnkSelectProblem.Name = "lnkSelectProblem";
            this.lnkSelectProblem.Size = new System.Drawing.Size(104, 18);
            this.lnkSelectProblem.TabIndex = 22;
            this.lnkSelectProblem.TabStop = true;
            this.lnkSelectProblem.Text = "♯問題一覧を表示";
            this.lnkSelectProblem.Visible = false;
            this.lnkSelectProblem.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.lnkSelectProblem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectProblem_LinkClicked);
            // 
            // RegexpPracticeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(634, 487);
            this.Controls.Add(this.pnlProblem);
            this.Controls.Add(this.lnkSelectProblem);
            this.Controls.Add(this.ckMultiLine);
            this.Controls.Add(this.ckIgnoreCase);
            this.Controls.Add(this.rtbAnnotation);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.lbReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.pnlModeSelect);
            this.Controls.Add(this.lbSystem);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.lbRegexp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegexp);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbProblem);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(650, 525);
            this.Name = "RegexpPracticeApp";
            this.Text = "Regur Express Siren!";
            this.Activated += new System.EventHandler(this.RegexpPracticeApp_Activated);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProblem)).EndInit();
            this.pnlModeSelect.ResumeLayout(false);
            this.pnlModeSelect.PerformLayout();
            this.pnlProblem.ResumeLayout(false);
            this.pnlProblem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconProblem;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.RichTextBox rtbProblem;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.TextBox tbRegexp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRegexp;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbSystem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlModeSelect;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbSearch;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Label lbReplace;
        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.RichTextBox rtbAnnotation;
        private System.Windows.Forms.CheckBox ckIgnoreCase;
        private System.Windows.Forms.CheckBox ckMultiLine;
        private System.Windows.Forms.Panel pnlProblem;
        private System.Windows.Forms.DataGridView dgvProblemList;
        private System.Windows.Forms.LinkLabel lnkCloseProblemList;
        private System.Windows.Forms.LinkLabel lnkEntryProblem;
        private System.Windows.Forms.LinkLabel lnkSelectProblem;
    }
}

