namespace RegexpPracticeApp {
    partial class ProblemEditForm {
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
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.btRegistry = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tbRegexp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btExecute = new System.Windows.Forms.Button();
            this.ckMultiLine = new System.Windows.Forms.CheckBox();
            this.ckIgnoreCase = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbAnnotation = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(91, 95);
            this.tbProblem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProblem.MaxLength = 500;
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(574, 66);
            this.tbProblem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "タイトル";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(91, 59);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTitle.MaxLength = 50;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(574, 25);
            this.tbTitle.TabIndex = 1;
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(91, 509);
            this.tbLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLevel.MaxLength = 3;
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(73, 25);
            this.tbLevel.TabIndex = 9;
            // 
            // btRegistry
            // 
            this.btRegistry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistry.ForeColor = System.Drawing.Color.White;
            this.btRegistry.Location = new System.Drawing.Point(574, 509);
            this.btRegistry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRegistry.Name = "btRegistry";
            this.btRegistry.Size = new System.Drawing.Size(91, 35);
            this.btRegistry.TabIndex = 14;
            this.btRegistry.Text = "登録";
            this.btRegistry.UseVisualStyleBackColor = false;
            this.btRegistry.Click += new System.EventHandler(this.btRegistry_Click);
            this.btRegistry.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.btRegistry.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(91, 435);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAnswer.MaxLength = 500;
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(574, 66);
            this.tbAnswer.TabIndex = 8;
            // 
            // rtbResult
            // 
            this.rtbResult.ForeColor = System.Drawing.Color.Black;
            this.rtbResult.Location = new System.Drawing.Point(91, 169);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbResult.MaxLength = 500;
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(574, 168);
            this.rtbResult.TabIndex = 3;
            this.rtbResult.Text = "";
            this.rtbResult.TextChanged += new System.EventHandler(this.rtbResult_TextChanged);
            // 
            // tbRegexp
            // 
            this.tbRegexp.Location = new System.Drawing.Point(91, 373);
            this.tbRegexp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbRegexp.Name = "tbRegexp";
            this.tbRegexp.Size = new System.Drawing.Size(477, 25);
            this.tbRegexp.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbRegexp, "問題の答えとなる正規表現を入力してください(DBには登録されません)");
            this.tbRegexp.TextChanged += new System.EventHandler(this.tbRegexp_TextChanged);
            this.tbRegexp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRegexp_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 25);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 25);
            this.panel2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "問題";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 169);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 45);
            this.panel3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "データ/\r\n実行結果";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(12, 373);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(73, 25);
            this.panel5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "正規表現";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(12, 435);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(73, 25);
            this.panel6.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "答え";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(12, 509);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(73, 25);
            this.panel7.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "難易度";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel8.Controls.Add(this.lb_Title);
            this.panel8.Location = new System.Drawing.Point(12, 13);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(653, 41);
            this.panel8.TabIndex = 29;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(3, 5);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(98, 31);
            this.lb_Title.TabIndex = 2;
            this.lb_Title.Text = "新規登録";
            // 
            // btExecute
            // 
            this.btExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExecute.ForeColor = System.Drawing.Color.White;
            this.btExecute.Location = new System.Drawing.Point(574, 373);
            this.btExecute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(91, 54);
            this.btExecute.TabIndex = 7;
            this.btExecute.Text = "正規表現実行";
            this.btExecute.UseVisualStyleBackColor = false;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            this.btExecute.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.btExecute.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // ckMultiLine
            // 
            this.ckMultiLine.AutoSize = true;
            this.ckMultiLine.Location = new System.Drawing.Point(190, 405);
            this.ckMultiLine.Name = "ckMultiLine";
            this.ckMultiLine.Size = new System.Drawing.Size(79, 22);
            this.ckMultiLine.TabIndex = 6;
            this.ckMultiLine.Text = "MultiLine";
            this.ckMultiLine.UseVisualStyleBackColor = true;
            this.ckMultiLine.CheckedChanged += new System.EventHandler(this.ckMultiLine_CheckedChanged);
            // 
            // ckIgnoreCase
            // 
            this.ckIgnoreCase.AutoSize = true;
            this.ckIgnoreCase.Location = new System.Drawing.Point(91, 405);
            this.ckIgnoreCase.Name = "ckIgnoreCase";
            this.ckIgnoreCase.Size = new System.Drawing.Size(93, 22);
            this.ckIgnoreCase.TabIndex = 5;
            this.ckIgnoreCase.Text = "IgnoreCase";
            this.ckIgnoreCase.UseVisualStyleBackColor = true;
            this.ckIgnoreCase.CheckedChanged += new System.EventHandler(this.ckIgnoreCase_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(344, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "※正規表現実行結果の状態も保存します";
            // 
            // rtbAnnotation
            // 
            this.rtbAnnotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbAnnotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAnnotation.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rtbAnnotation.Location = new System.Drawing.Point(91, 339);
            this.rtbAnnotation.Name = "rtbAnnotation";
            this.rtbAnnotation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbAnnotation.Size = new System.Drawing.Size(574, 22);
            this.rtbAnnotation.TabIndex = 34;
            this.rtbAnnotation.Text = "※正規表現全体に一致⇒緑背景色／カッコに一致⇒緑背景色＋太字";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(477, 509);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(91, 35);
            this.btCancel.TabIndex = 35;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            this.btCancel.MouseEnter += new System.EventHandler(this.bt_MouseEnter);
            this.btCancel.MouseLeave += new System.EventHandler(this.bt_MouseLeave);
            // 
            // ProblemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 559);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.rtbAnnotation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckMultiLine);
            this.Controls.Add(this.ckIgnoreCase);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbRegexp);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btRegistry);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbProblem);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProblemEditForm";
            this.Text = "ProblemEditForm";
            this.Activated += new System.EventHandler(this.ProblemEditForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Button btRegistry;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.TextBox tbRegexp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.CheckBox ckMultiLine;
        private System.Windows.Forms.CheckBox ckIgnoreCase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbAnnotation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btCancel;
    }
}