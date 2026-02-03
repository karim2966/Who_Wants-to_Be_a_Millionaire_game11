namespace ITE_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laLevel = new System.Windows.Forms.Label();
            this.LaMoney = new System.Windows.Forms.Label();
            this.laCurrent = new System.Windows.Forms.Label();
            this.BStartGame = new System.Windows.Forms.Button();
            this.LaQuestionView = new System.Windows.Forms.Label();
            this.L200 = new System.Windows.Forms.Label();
            this.L300 = new System.Windows.Forms.Label();
            this.L500 = new System.Windows.Forms.Label();
            this.L4000 = new System.Windows.Forms.Label();
            this.L16000 = new System.Windows.Forms.Label();
            this.L32000 = new System.Windows.Forms.Label();
            this.L64000 = new System.Windows.Forms.Label();
            this.L125000 = new System.Windows.Forms.Label();
            this.L250000 = new System.Windows.Forms.Label();
            this.L500000 = new System.Windows.Forms.Label();
            this.L1000000 = new System.Windows.Forms.Label();
            this.L8000 = new System.Windows.Forms.Label();
            this.L1000 = new System.Windows.Forms.Label();
            this.L2000 = new System.Windows.Forms.Label();
            this.BSwitchQuestion = new System.Windows.Forms.Button();
            this.B5050 = new System.Windows.Forms.Button();
            this.BWithdraw = new System.Windows.Forms.Button();
            this.BAnswerA = new System.Windows.Forms.Button();
            this.BAnswerB = new System.Windows.Forms.Button();
            this.BAnswerC = new System.Windows.Forms.Button();
            this.BAnswerD = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.L100 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laLevel
            // 
            this.laLevel.BackColor = System.Drawing.Color.MidnightBlue;
            this.laLevel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.laLevel.ForeColor = System.Drawing.Color.Gold;
            this.laLevel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.laLevel.Location = new System.Drawing.Point(30, 12);
            this.laLevel.Name = "laLevel";
            this.laLevel.Size = new System.Drawing.Size(105, 33);
            this.laLevel.TabIndex = 2;
            this.laLevel.Text = "level:";
            // 
            // LaMoney
            // 
            this.LaMoney.BackColor = System.Drawing.Color.MidnightBlue;
            this.LaMoney.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LaMoney.ForeColor = System.Drawing.Color.Gold;
            this.LaMoney.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LaMoney.Location = new System.Drawing.Point(141, 12);
            this.LaMoney.Name = "LaMoney";
            this.LaMoney.Size = new System.Drawing.Size(196, 33);
            this.LaMoney.TabIndex = 4;
            this.LaMoney.Text = "Money:$0";
            // 
            // laCurrent
            // 
            this.laCurrent.BackColor = System.Drawing.Color.MidnightBlue;
            this.laCurrent.Font = new System.Drawing.Font("Tahoma", 14F);
            this.laCurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laCurrent.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.laCurrent.Location = new System.Drawing.Point(359, 12);
            this.laCurrent.Name = "laCurrent";
            this.laCurrent.Size = new System.Drawing.Size(219, 33);
            this.laCurrent.TabIndex = 7;
            this.laCurrent.Text = "Current:$0";
            // 
            // BStartGame
            // 
            this.BStartGame.AutoSize = true;
            this.BStartGame.BackColor = System.Drawing.Color.SlateGray;
            this.BStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BStartGame.FlatAppearance.BorderSize = 3;
            this.BStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BStartGame.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BStartGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BStartGame.Location = new System.Drawing.Point(607, 12);
            this.BStartGame.Name = "BStartGame";
            this.BStartGame.Size = new System.Drawing.Size(165, 88);
            this.BStartGame.TabIndex = 15;
            this.BStartGame.Text = "start game";
            this.BStartGame.UseVisualStyleBackColor = false;
            this.BStartGame.Click += new System.EventHandler(this.BStartGame_Click);
            // 
            // LaQuestionView
            // 
            this.LaQuestionView.BackColor = System.Drawing.Color.SlateGray;
            this.LaQuestionView.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LaQuestionView.ForeColor = System.Drawing.Color.Gold;
            this.LaQuestionView.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LaQuestionView.Location = new System.Drawing.Point(14, 72);
            this.LaQuestionView.Name = "LaQuestionView";
            this.LaQuestionView.Size = new System.Drawing.Size(581, 90);
            this.LaQuestionView.TabIndex = 19;
            this.LaQuestionView.Text = "Question  will appear  here";
            this.LaQuestionView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L200
            // 
            this.L200.BackColor = System.Drawing.Color.SlateGray;
            this.L200.ForeColor = System.Drawing.Color.Gold;
            this.L200.Location = new System.Drawing.Point(3, 264);
            this.L200.Name = "L200";
            this.L200.Size = new System.Drawing.Size(161, 20);
            this.L200.TabIndex = 13;
            this.L200.Text = "$200";
            // 
            // L300
            // 
            this.L300.BackColor = System.Drawing.Color.SlateGray;
            this.L300.ForeColor = System.Drawing.Color.Gold;
            this.L300.Location = new System.Drawing.Point(3, 244);
            this.L300.Name = "L300";
            this.L300.Size = new System.Drawing.Size(161, 20);
            this.L300.TabIndex = 12;
            this.L300.Text = "$300";
            // 
            // L500
            // 
            this.L500.BackColor = System.Drawing.Color.SlateGray;
            this.L500.ForeColor = System.Drawing.Color.Gold;
            this.L500.Location = new System.Drawing.Point(3, 224);
            this.L500.Name = "L500";
            this.L500.Size = new System.Drawing.Size(161, 20);
            this.L500.TabIndex = 11;
            this.L500.Text = "$500";
            // 
            // L4000
            // 
            this.L4000.BackColor = System.Drawing.Color.SlateGray;
            this.L4000.ForeColor = System.Drawing.Color.Gold;
            this.L4000.Location = new System.Drawing.Point(3, 164);
            this.L4000.Name = "L4000";
            this.L4000.Size = new System.Drawing.Size(161, 20);
            this.L4000.TabIndex = 8;
            this.L4000.Text = "$4,000";
            // 
            // L16000
            // 
            this.L16000.BackColor = System.Drawing.Color.SlateGray;
            this.L16000.ForeColor = System.Drawing.Color.Gold;
            this.L16000.Location = new System.Drawing.Point(3, 124);
            this.L16000.Name = "L16000";
            this.L16000.Size = new System.Drawing.Size(161, 20);
            this.L16000.TabIndex = 6;
            this.L16000.Text = "$16,000";
            // 
            // L32000
            // 
            this.L32000.BackColor = System.Drawing.Color.SlateGray;
            this.L32000.ForeColor = System.Drawing.Color.Gold;
            this.L32000.Location = new System.Drawing.Point(3, 104);
            this.L32000.Name = "L32000";
            this.L32000.Size = new System.Drawing.Size(161, 20);
            this.L32000.TabIndex = 5;
            this.L32000.Text = "$32,000";
            // 
            // L64000
            // 
            this.L64000.BackColor = System.Drawing.Color.SlateGray;
            this.L64000.ForeColor = System.Drawing.Color.Gold;
            this.L64000.Location = new System.Drawing.Point(3, 84);
            this.L64000.Name = "L64000";
            this.L64000.Size = new System.Drawing.Size(161, 20);
            this.L64000.TabIndex = 4;
            this.L64000.Text = "$64,000";
            // 
            // L125000
            // 
            this.L125000.BackColor = System.Drawing.Color.SlateGray;
            this.L125000.ForeColor = System.Drawing.Color.Gold;
            this.L125000.Location = new System.Drawing.Point(3, 64);
            this.L125000.Name = "L125000";
            this.L125000.Size = new System.Drawing.Size(161, 20);
            this.L125000.TabIndex = 3;
            this.L125000.Text = "$125,000";
            // 
            // L250000
            // 
            this.L250000.BackColor = System.Drawing.Color.SlateGray;
            this.L250000.ForeColor = System.Drawing.Color.Gold;
            this.L250000.Location = new System.Drawing.Point(3, 44);
            this.L250000.Name = "L250000";
            this.L250000.Size = new System.Drawing.Size(161, 20);
            this.L250000.TabIndex = 2;
            this.L250000.Text = "$250,000";
            // 
            // L500000
            // 
            this.L500000.BackColor = System.Drawing.Color.SlateGray;
            this.L500000.ForeColor = System.Drawing.Color.Gold;
            this.L500000.Location = new System.Drawing.Point(3, 24);
            this.L500000.Name = "L500000";
            this.L500000.Size = new System.Drawing.Size(161, 20);
            this.L500000.TabIndex = 1;
            this.L500000.Text = "$500,000";
            // 
            // L1000000
            // 
            this.L1000000.BackColor = System.Drawing.Color.SlateGray;
            this.L1000000.ForeColor = System.Drawing.Color.Gold;
            this.L1000000.Location = new System.Drawing.Point(3, 4);
            this.L1000000.Name = "L1000000";
            this.L1000000.Size = new System.Drawing.Size(161, 20);
            this.L1000000.TabIndex = 0;
            this.L1000000.Text = "$1,000,000";
            // 
            // L8000
            // 
            this.L8000.BackColor = System.Drawing.Color.SlateGray;
            this.L8000.ForeColor = System.Drawing.Color.Gold;
            this.L8000.Location = new System.Drawing.Point(3, 144);
            this.L8000.Name = "L8000";
            this.L8000.Size = new System.Drawing.Size(161, 20);
            this.L8000.TabIndex = 7;
            this.L8000.Text = "$8,000";
            // 
            // L1000
            // 
            this.L1000.BackColor = System.Drawing.Color.SlateGray;
            this.L1000.ForeColor = System.Drawing.Color.Gold;
            this.L1000.Location = new System.Drawing.Point(3, 204);
            this.L1000.Name = "L1000";
            this.L1000.Size = new System.Drawing.Size(161, 20);
            this.L1000.TabIndex = 10;
            this.L1000.Text = "$1,000";
            // 
            // L2000
            // 
            this.L2000.BackColor = System.Drawing.Color.SlateGray;
            this.L2000.ForeColor = System.Drawing.Color.Gold;
            this.L2000.Location = new System.Drawing.Point(3, 184);
            this.L2000.Name = "L2000";
            this.L2000.Size = new System.Drawing.Size(161, 20);
            this.L2000.TabIndex = 9;
            this.L2000.Text = "$2,000";
            // 
            // BSwitchQuestion
            // 
            this.BSwitchQuestion.AutoSize = true;
            this.BSwitchQuestion.BackColor = System.Drawing.Color.SlateGray;
            this.BSwitchQuestion.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BSwitchQuestion.FlatAppearance.BorderSize = 3;
            this.BSwitchQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSwitchQuestion.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BSwitchQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BSwitchQuestion.Location = new System.Drawing.Point(310, 188);
            this.BSwitchQuestion.Name = "BSwitchQuestion";
            this.BSwitchQuestion.Size = new System.Drawing.Size(285, 45);
            this.BSwitchQuestion.TabIndex = 22;
            this.BSwitchQuestion.Text = "Switch Question";
            this.BSwitchQuestion.UseVisualStyleBackColor = false;
            this.BSwitchQuestion.Click += new System.EventHandler(this.BSwitch_Click);
            // 
            // B5050
            // 
            this.B5050.AutoSize = true;
            this.B5050.BackColor = System.Drawing.Color.SlateGray;
            this.B5050.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.B5050.FlatAppearance.BorderSize = 3;
            this.B5050.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B5050.Font = new System.Drawing.Font("Tahoma", 12F);
            this.B5050.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B5050.Location = new System.Drawing.Point(19, 188);
            this.B5050.Name = "B5050";
            this.B5050.Size = new System.Drawing.Size(285, 45);
            this.B5050.TabIndex = 23;
            this.B5050.Text = "50:50";
            this.B5050.UseVisualStyleBackColor = false;
            this.B5050.Click += new System.EventHandler(this.B5050_Click);
            // 
            // BWithdraw
            // 
            this.BWithdraw.AutoSize = true;
            this.BWithdraw.BackColor = System.Drawing.Color.SlateGray;
            this.BWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BWithdraw.FlatAppearance.BorderSize = 3;
            this.BWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BWithdraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BWithdraw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BWithdraw.Location = new System.Drawing.Point(21, 426);
            this.BWithdraw.Name = "BWithdraw";
            this.BWithdraw.Size = new System.Drawing.Size(741, 45);
            this.BWithdraw.TabIndex = 24;
            this.BWithdraw.Text = "Withdraw";
            this.BWithdraw.UseVisualStyleBackColor = false;
            this.BWithdraw.Click += new System.EventHandler(this.BWithdraw_Click);
            // 
            // BAnswerA
            // 
            this.BAnswerA.AutoSize = true;
            this.BAnswerA.BackColor = System.Drawing.Color.SlateGray;
            this.BAnswerA.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BAnswerA.FlatAppearance.BorderSize = 3;
            this.BAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnswerA.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BAnswerA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BAnswerA.Location = new System.Drawing.Point(19, 239);
            this.BAnswerA.Name = "BAnswerA";
            this.BAnswerA.Size = new System.Drawing.Size(285, 82);
            this.BAnswerA.TabIndex = 25;
            this.BAnswerA.Text = "A";
            this.BAnswerA.UseVisualStyleBackColor = false;
            this.BAnswerA.Click += new System.EventHandler(this.BAnswerA_Click);
            // 
            // BAnswerB
            // 
            this.BAnswerB.AutoSize = true;
            this.BAnswerB.BackColor = System.Drawing.Color.SlateGray;
            this.BAnswerB.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BAnswerB.FlatAppearance.BorderSize = 3;
            this.BAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnswerB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BAnswerB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BAnswerB.Location = new System.Drawing.Point(310, 239);
            this.BAnswerB.Name = "BAnswerB";
            this.BAnswerB.Size = new System.Drawing.Size(285, 82);
            this.BAnswerB.TabIndex = 26;
            this.BAnswerB.Text = "B";
            this.BAnswerB.UseVisualStyleBackColor = false;
            this.BAnswerB.Click += new System.EventHandler(this.BAnswerB_Click);
            // 
            // BAnswerC
            // 
            this.BAnswerC.AutoSize = true;
            this.BAnswerC.BackColor = System.Drawing.Color.SlateGray;
            this.BAnswerC.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BAnswerC.FlatAppearance.BorderSize = 3;
            this.BAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnswerC.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BAnswerC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BAnswerC.Location = new System.Drawing.Point(21, 328);
            this.BAnswerC.Name = "BAnswerC";
            this.BAnswerC.Size = new System.Drawing.Size(285, 82);
            this.BAnswerC.TabIndex = 27;
            this.BAnswerC.Text = "C";
            this.BAnswerC.UseVisualStyleBackColor = false;
            this.BAnswerC.Click += new System.EventHandler(this.BAnswerC_Click);
            // 
            // BAnswerD
            // 
            this.BAnswerD.AutoSize = true;
            this.BAnswerD.BackColor = System.Drawing.Color.SlateGray;
            this.BAnswerD.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BAnswerD.FlatAppearance.BorderSize = 3;
            this.BAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnswerD.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BAnswerD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BAnswerD.Location = new System.Drawing.Point(310, 328);
            this.BAnswerD.Name = "BAnswerD";
            this.BAnswerD.Size = new System.Drawing.Size(285, 82);
            this.BAnswerD.TabIndex = 28;
            this.BAnswerD.Text = "D";
            this.BAnswerD.UseVisualStyleBackColor = false;
            this.BAnswerD.Click += new System.EventHandler(this.BAnswerD_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.L100, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.L200, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.L300, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.L500, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.L4000, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.L16000, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.L32000, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.L64000, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.L250000, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.L8000, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.L125000, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.L1000, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.L1000000, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L500000, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.L2000, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(601, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 304);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // L100
            // 
            this.L100.BackColor = System.Drawing.Color.SlateGray;
            this.L100.ForeColor = System.Drawing.Color.Gold;
            this.L100.Location = new System.Drawing.Point(3, 284);
            this.L100.Name = "L100";
            this.L100.Size = new System.Drawing.Size(161, 20);
            this.L100.TabIndex = 14;
            this.L100.Text = "$100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BAnswerD);
            this.Controls.Add(this.BAnswerC);
            this.Controls.Add(this.BAnswerB);
            this.Controls.Add(this.BAnswerA);
            this.Controls.Add(this.BWithdraw);
            this.Controls.Add(this.B5050);
            this.Controls.Add(this.BSwitchQuestion);
            this.Controls.Add(this.laCurrent);
            this.Controls.Add(this.LaQuestionView);
            this.Controls.Add(this.BStartGame);
            this.Controls.Add(this.LaMoney);
            this.Controls.Add(this.laLevel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Wants To Be a Millionaire";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laLevel;
        private System.Windows.Forms.Label LaMoney;
        private System.Windows.Forms.Label laCurrent;
        private System.Windows.Forms.Button BStartGame;
        private System.Windows.Forms.Label LaQuestionView;
        private System.Windows.Forms.Label L200;
        private System.Windows.Forms.Label L300;
        private System.Windows.Forms.Label L500;
        private System.Windows.Forms.Label L1000;
        private System.Windows.Forms.Label L2000;
        private System.Windows.Forms.Label L4000;
        private System.Windows.Forms.Label L8000;
        private System.Windows.Forms.Label L16000;
        private System.Windows.Forms.Label L32000;
        private System.Windows.Forms.Label L64000;
        private System.Windows.Forms.Label L125000;
        private System.Windows.Forms.Label L250000;
        private System.Windows.Forms.Label L500000;
        private System.Windows.Forms.Label L1000000;
        private System.Windows.Forms.Button BSwitchQuestion;
        private System.Windows.Forms.Button B5050;
        private System.Windows.Forms.Button BWithdraw;
        private System.Windows.Forms.Button BAnswerA;
        private System.Windows.Forms.Button BAnswerB;
        private System.Windows.Forms.Button BAnswerC;
        private System.Windows.Forms.Button BAnswerD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label L100;
    }
}

