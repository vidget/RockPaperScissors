namespace RockPaperScissors
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKToGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wonTextLabel = new System.Windows.Forms.Label();
            this.lostTextLabel = new System.Windows.Forms.Label();
            this.tiedTextLabel = new System.Windows.Forms.Label();
            this.wonStat = new System.Windows.Forms.Label();
            this.lostStat = new System.Windows.Forms.Label();
            this.tiedStat = new System.Windows.Forms.Label();
            this.gamesStat = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.labelTie = new System.Windows.Forms.Label();
            this.labelLosses = new System.Windows.Forms.Label();
            this.dialogLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.labelGamesPlayed = new System.Windows.Forms.PictureBox();
            this.labelWon = new System.Windows.Forms.PictureBox();
            this.labelLost = new System.Windows.Forms.PictureBox();
            this.labelTied = new System.Windows.Forms.PictureBox();
            this.selectPrompt = new System.Windows.Forms.PictureBox();
            this.image_Lt_Rock = new System.Windows.Forms.PictureBox();
            this.image_Lt_Scissors = new System.Windows.Forms.PictureBox();
            this.image_Lt_Paper = new System.Windows.Forms.PictureBox();
            this.image_Rt_Paper = new System.Windows.Forms.PictureBox();
            this.image_Rt_Rock = new System.Windows.Forms.PictureBox();
            this.image_Rt_Scissors = new System.Windows.Forms.PictureBox();
            this.dialogOpen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGamesPlayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPrompt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Scissors)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.bACKToGAMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // bACKToGAMEToolStripMenuItem
            // 
            this.bACKToGAMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bACKToGAMEToolStripMenuItem.Name = "bACKToGAMEToolStripMenuItem";
            this.bACKToGAMEToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.bACKToGAMEToolStripMenuItem.Text = "BACK to GAME";
            this.bACKToGAMEToolStripMenuItem.Click += new System.EventHandler(this.bACKToGAMEToolStripMenuItem_Click);
            // 
            // wonTextLabel
            // 
            this.wonTextLabel.AutoSize = true;
            this.wonTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.wonTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonTextLabel.ForeColor = System.Drawing.Color.White;
            this.wonTextLabel.Location = new System.Drawing.Point(433, 75);
            this.wonTextLabel.Name = "wonTextLabel";
            this.wonTextLabel.Size = new System.Drawing.Size(40, 42);
            this.wonTextLabel.TabIndex = 16;
            this.wonTextLabel.Text = "0";
            this.wonTextLabel.Visible = false;
            // 
            // lostTextLabel
            // 
            this.lostTextLabel.AutoSize = true;
            this.lostTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.lostTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostTextLabel.ForeColor = System.Drawing.Color.White;
            this.lostTextLabel.Location = new System.Drawing.Point(695, 75);
            this.lostTextLabel.Name = "lostTextLabel";
            this.lostTextLabel.Size = new System.Drawing.Size(40, 42);
            this.lostTextLabel.TabIndex = 17;
            this.lostTextLabel.Text = "0";
            this.lostTextLabel.Visible = false;
            // 
            // tiedTextLabel
            // 
            this.tiedTextLabel.AutoSize = true;
            this.tiedTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.tiedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiedTextLabel.ForeColor = System.Drawing.Color.White;
            this.tiedTextLabel.Location = new System.Drawing.Point(564, 75);
            this.tiedTextLabel.Name = "tiedTextLabel";
            this.tiedTextLabel.Size = new System.Drawing.Size(40, 42);
            this.tiedTextLabel.TabIndex = 18;
            this.tiedTextLabel.Text = "0";
            this.tiedTextLabel.Visible = false;
            // 
            // wonStat
            // 
            this.wonStat.AutoSize = true;
            this.wonStat.BackColor = System.Drawing.Color.Transparent;
            this.wonStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonStat.ForeColor = System.Drawing.Color.White;
            this.wonStat.Location = new System.Drawing.Point(637, 199);
            this.wonStat.Name = "wonStat";
            this.wonStat.Size = new System.Drawing.Size(69, 73);
            this.wonStat.TabIndex = 19;
            this.wonStat.Text = "0";
            this.wonStat.Visible = false;
            // 
            // lostStat
            // 
            this.lostStat.AutoSize = true;
            this.lostStat.BackColor = System.Drawing.Color.Transparent;
            this.lostStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostStat.ForeColor = System.Drawing.Color.White;
            this.lostStat.Location = new System.Drawing.Point(637, 282);
            this.lostStat.Name = "lostStat";
            this.lostStat.Size = new System.Drawing.Size(69, 73);
            this.lostStat.TabIndex = 20;
            this.lostStat.Text = "0";
            this.lostStat.Visible = false;
            // 
            // tiedStat
            // 
            this.tiedStat.AutoSize = true;
            this.tiedStat.BackColor = System.Drawing.Color.Transparent;
            this.tiedStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiedStat.ForeColor = System.Drawing.Color.White;
            this.tiedStat.Location = new System.Drawing.Point(637, 365);
            this.tiedStat.Name = "tiedStat";
            this.tiedStat.Size = new System.Drawing.Size(69, 73);
            this.tiedStat.TabIndex = 21;
            this.tiedStat.Text = "0";
            this.tiedStat.Visible = false;
            // 
            // gamesStat
            // 
            this.gamesStat.AutoSize = true;
            this.gamesStat.BackColor = System.Drawing.Color.Transparent;
            this.gamesStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesStat.ForeColor = System.Drawing.Color.White;
            this.gamesStat.Location = new System.Drawing.Point(294, 98);
            this.gamesStat.Name = "gamesStat";
            this.gamesStat.Size = new System.Drawing.Size(73, 79);
            this.gamesStat.TabIndex = 22;
            this.gamesStat.Text = "0";
            this.gamesStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gamesStat.Visible = false;
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.White;
            this.labelWin.Location = new System.Drawing.Point(435, 58);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(39, 15);
            this.labelWin.TabIndex = 23;
            this.labelWin.Text = "WON";
            this.labelWin.Visible = false;
            // 
            // labelTie
            // 
            this.labelTie.AutoSize = true;
            this.labelTie.BackColor = System.Drawing.Color.Transparent;
            this.labelTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTie.ForeColor = System.Drawing.Color.White;
            this.labelTie.Location = new System.Drawing.Point(569, 58);
            this.labelTie.Name = "labelTie";
            this.labelTie.Size = new System.Drawing.Size(38, 15);
            this.labelTie.TabIndex = 24;
            this.labelTie.Text = "TIED";
            this.labelTie.Visible = false;
            // 
            // labelLosses
            // 
            this.labelLosses.AutoSize = true;
            this.labelLosses.BackColor = System.Drawing.Color.Transparent;
            this.labelLosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLosses.ForeColor = System.Drawing.Color.White;
            this.labelLosses.Location = new System.Drawing.Point(695, 58);
            this.labelLosses.Name = "labelLosses";
            this.labelLosses.Size = new System.Drawing.Size(43, 15);
            this.labelLosses.TabIndex = 25;
            this.labelLosses.Text = "LOSS";
            this.labelLosses.Visible = false;
            // 
            // dialogLabel
            // 
            this.dialogLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogLabel.AutoSize = true;
            this.dialogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogLabel.ForeColor = System.Drawing.Color.White;
            this.dialogLabel.Location = new System.Drawing.Point(457, 423);
            this.dialogLabel.Name = "dialogLabel";
            this.dialogLabel.Size = new System.Drawing.Size(0, 16);
            this.dialogLabel.TabIndex = 27;
            this.dialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.BackgroundImage = global::RockPaperScissors.Properties.Resources.image_51;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.Location = new System.Drawing.Point(528, 461);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 127);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonScissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.scissorsButton;
            this.buttonScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonScissors.FlatAppearance.BorderSize = 0;
            this.buttonScissors.Location = new System.Drawing.Point(690, 461);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(132, 127);
            this.buttonScissors.TabIndex = 2;
            this.buttonScissors.UseVisualStyleBackColor = false;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPaper.BackgroundImage = global::RockPaperScissors.Properties.Resources.paperButton;
            this.buttonPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPaper.FlatAppearance.BorderSize = 0;
            this.buttonPaper.Location = new System.Drawing.Point(528, 461);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(132, 127);
            this.buttonPaper.TabIndex = 1;
            this.buttonPaper.UseVisualStyleBackColor = false;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRock.BackgroundImage = global::RockPaperScissors.Properties.Resources.rockButton;
            this.buttonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRock.FlatAppearance.BorderSize = 0;
            this.buttonRock.Location = new System.Drawing.Point(369, 461);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(132, 127);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.UseVisualStyleBackColor = false;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // labelGamesPlayed
            // 
            this.labelGamesPlayed.BackColor = System.Drawing.Color.Transparent;
            this.labelGamesPlayed.Image = global::RockPaperScissors.Properties.Resources.gamesPlayedLabel;
            this.labelGamesPlayed.Location = new System.Drawing.Point(442, 118);
            this.labelGamesPlayed.Name = "labelGamesPlayed";
            this.labelGamesPlayed.Size = new System.Drawing.Size(423, 78);
            this.labelGamesPlayed.TabIndex = 11;
            this.labelGamesPlayed.TabStop = false;
            this.labelGamesPlayed.Visible = false;
            // 
            // labelWon
            // 
            this.labelWon.BackColor = System.Drawing.Color.Transparent;
            this.labelWon.Image = global::RockPaperScissors.Properties.Resources.gamesWonLabel;
            this.labelWon.Location = new System.Drawing.Point(461, 212);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(139, 78);
            this.labelWon.TabIndex = 12;
            this.labelWon.TabStop = false;
            this.labelWon.Visible = false;
            // 
            // labelLost
            // 
            this.labelLost.BackColor = System.Drawing.Color.Transparent;
            this.labelLost.Image = global::RockPaperScissors.Properties.Resources.gamesLostLabel;
            this.labelLost.Location = new System.Drawing.Point(461, 296);
            this.labelLost.Name = "labelLost";
            this.labelLost.Size = new System.Drawing.Size(148, 78);
            this.labelLost.TabIndex = 13;
            this.labelLost.TabStop = false;
            this.labelLost.Visible = false;
            // 
            // labelTied
            // 
            this.labelTied.BackColor = System.Drawing.Color.Transparent;
            this.labelTied.Image = global::RockPaperScissors.Properties.Resources.gamesTiedLabel;
            this.labelTied.Location = new System.Drawing.Point(461, 380);
            this.labelTied.Name = "labelTied";
            this.labelTied.Size = new System.Drawing.Size(148, 78);
            this.labelTied.TabIndex = 14;
            this.labelTied.TabStop = false;
            this.labelTied.Visible = false;
            // 
            // selectPrompt
            // 
            this.selectPrompt.BackColor = System.Drawing.Color.Transparent;
            this.selectPrompt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectPrompt.Image = global::RockPaperScissors.Properties.Resources.selectionPromptTitleFINAL;
            this.selectPrompt.Location = new System.Drawing.Point(254, 193);
            this.selectPrompt.Name = "selectPrompt";
            this.selectPrompt.Size = new System.Drawing.Size(653, 223);
            this.selectPrompt.TabIndex = 10;
            this.selectPrompt.TabStop = false;
            // 
            // image_Lt_Rock
            // 
            this.image_Lt_Rock.BackColor = System.Drawing.Color.Transparent;
            this.image_Lt_Rock.BackgroundImage = global::RockPaperScissors.Properties.Resources.ltRock1;
            this.image_Lt_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_Lt_Rock.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.image_Lt_Rock.InitialImage = null;
            this.image_Lt_Rock.Location = new System.Drawing.Point(-3, 121);
            this.image_Lt_Rock.Name = "image_Lt_Rock";
            this.image_Lt_Rock.Size = new System.Drawing.Size(550, 334);
            this.image_Lt_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Lt_Rock.TabIndex = 6;
            this.image_Lt_Rock.TabStop = false;
            this.image_Lt_Rock.UseWaitCursor = true;
            this.image_Lt_Rock.Visible = false;
            // 
            // image_Lt_Scissors
            // 
            this.image_Lt_Scissors.BackColor = System.Drawing.Color.Transparent;
            this.image_Lt_Scissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.ltScissors;
            this.image_Lt_Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_Lt_Scissors.Location = new System.Drawing.Point(-3, 130);
            this.image_Lt_Scissors.Name = "image_Lt_Scissors";
            this.image_Lt_Scissors.Size = new System.Drawing.Size(569, 284);
            this.image_Lt_Scissors.TabIndex = 8;
            this.image_Lt_Scissors.TabStop = false;
            this.image_Lt_Scissors.Visible = false;
            // 
            // image_Lt_Paper
            // 
            this.image_Lt_Paper.BackColor = System.Drawing.Color.Transparent;
            this.image_Lt_Paper.BackgroundImage = global::RockPaperScissors.Properties.Resources.ltPaper;
            this.image_Lt_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_Lt_Paper.Location = new System.Drawing.Point(-3, 113);
            this.image_Lt_Paper.Name = "image_Lt_Paper";
            this.image_Lt_Paper.Size = new System.Drawing.Size(584, 342);
            this.image_Lt_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Lt_Paper.TabIndex = 7;
            this.image_Lt_Paper.TabStop = false;
            this.image_Lt_Paper.Visible = false;
            // 
            // image_Rt_Paper
            // 
            this.image_Rt_Paper.BackColor = System.Drawing.Color.Transparent;
            this.image_Rt_Paper.BackgroundImage = global::RockPaperScissors.Properties.Resources.rtPaper1;
            this.image_Rt_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_Rt_Paper.Location = new System.Drawing.Point(587, 121);
            this.image_Rt_Paper.Name = "image_Rt_Paper";
            this.image_Rt_Paper.Size = new System.Drawing.Size(562, 334);
            this.image_Rt_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Rt_Paper.TabIndex = 5;
            this.image_Rt_Paper.TabStop = false;
            this.image_Rt_Paper.Visible = false;
            // 
            // image_Rt_Rock
            // 
            this.image_Rt_Rock.BackColor = System.Drawing.Color.Transparent;
            this.image_Rt_Rock.BackgroundImage = global::RockPaperScissors.Properties.Resources.rtRock;
            this.image_Rt_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_Rt_Rock.Location = new System.Drawing.Point(618, 105);
            this.image_Rt_Rock.Name = "image_Rt_Rock";
            this.image_Rt_Rock.Size = new System.Drawing.Size(533, 334);
            this.image_Rt_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Rt_Rock.TabIndex = 4;
            this.image_Rt_Rock.TabStop = false;
            this.image_Rt_Rock.Visible = false;
            // 
            // image_Rt_Scissors
            // 
            this.image_Rt_Scissors.BackColor = System.Drawing.Color.Transparent;
            this.image_Rt_Scissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.rtScissors;
            this.image_Rt_Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_Rt_Scissors.Location = new System.Drawing.Point(585, 141);
            this.image_Rt_Scissors.Name = "image_Rt_Scissors";
            this.image_Rt_Scissors.Size = new System.Drawing.Size(564, 273);
            this.image_Rt_Scissors.TabIndex = 3;
            this.image_Rt_Scissors.TabStop = false;
            this.image_Rt_Scissors.Visible = false;
            // 
            // dialogOpen
            // 
            this.dialogOpen.AutoSize = true;
            this.dialogOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogOpen.ForeColor = System.Drawing.Color.White;
            this.dialogOpen.Location = new System.Drawing.Point(501, 423);
            this.dialogOpen.Name = "dialogOpen";
            this.dialogOpen.Size = new System.Drawing.Size(126, 16);
            this.dialogOpen.TabIndex = 28;
            this.dialogOpen.Text = "Choose Carefully";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1151, 631);
            this.Controls.Add(this.dialogOpen);
            this.Controls.Add(this.dialogLabel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelLosses);
            this.Controls.Add(this.labelTie);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.tiedStat);
            this.Controls.Add(this.lostStat);
            this.Controls.Add(this.wonStat);
            this.Controls.Add(this.tiedTextLabel);
            this.Controls.Add(this.lostTextLabel);
            this.Controls.Add(this.wonTextLabel);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelGamesPlayed);
            this.Controls.Add(this.labelWon);
            this.Controls.Add(this.labelLost);
            this.Controls.Add(this.labelTied);
            this.Controls.Add(this.selectPrompt);
            this.Controls.Add(this.gamesStat);
            this.Controls.Add(this.image_Rt_Paper);
            this.Controls.Add(this.image_Rt_Rock);
            this.Controls.Add(this.image_Rt_Scissors);
            this.Controls.Add(this.image_Lt_Rock);
            this.Controls.Add(this.image_Lt_Scissors);
            this.Controls.Add(this.image_Lt_Paper);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGamesPlayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelTied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPrompt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Lt_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_Rt_Scissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.PictureBox image_Rt_Scissors;
        private System.Windows.Forms.PictureBox image_Rt_Rock;
        private System.Windows.Forms.PictureBox image_Rt_Paper;
        private System.Windows.Forms.PictureBox image_Lt_Rock;
        private System.Windows.Forms.PictureBox image_Lt_Paper;
        private System.Windows.Forms.PictureBox image_Lt_Scissors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.PictureBox selectPrompt;
        private System.Windows.Forms.PictureBox labelGamesPlayed;
        private System.Windows.Forms.PictureBox labelWon;
        private System.Windows.Forms.PictureBox labelLost;
        private System.Windows.Forms.PictureBox labelTied;
        private System.Windows.Forms.Label wonTextLabel;
        private System.Windows.Forms.Label lostTextLabel;
        private System.Windows.Forms.Label tiedTextLabel;
        private System.Windows.Forms.Label wonStat;
        private System.Windows.Forms.Label lostStat;
        private System.Windows.Forms.Label tiedStat;
        private System.Windows.Forms.Label gamesStat;
        private System.Windows.Forms.ToolStripMenuItem bACKToGAMEToolStripMenuItem;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelTie;
        private System.Windows.Forms.Label labelLosses;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label dialogLabel;
        private System.Windows.Forms.Label dialogOpen;
    }
}

