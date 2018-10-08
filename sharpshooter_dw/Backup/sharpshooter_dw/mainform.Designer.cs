namespace sharpshooter_dw
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlepic = new System.Windows.Forms.PictureBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.NextLevelPic = new System.Windows.Forms.Label();
            this.HealthCounter = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Label();
            this.Medium = new System.Windows.Forms.Label();
            this.Realistic = new System.Windows.Forms.Label();
            this.LevelLBL = new System.Windows.Forms.Label();
            this.Pistolpic = new System.Windows.Forms.PictureBox();
            this.RapidGunpic = new System.Windows.Forms.PictureBox();
            this.Sniperpic = new System.Windows.Forms.PictureBox();
            this.SuperBallpic = new System.Windows.Forms.PictureBox();
            this.Stunpic = new System.Windows.Forms.PictureBox();
            this.PauseButton = new System.Windows.Forms.Label();
            this.Paused = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistolpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapidGunpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sniperpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperBallpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stunpic)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Interval = 25;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(792, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // RestartToolStripMenuItem
            // 
            this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            this.RestartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.RestartToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RestartToolStripMenuItem.Text = "Restart";
            this.RestartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.cheatsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cheatsToolStripMenuItem.Text = "Cheats";
            this.cheatsToolStripMenuItem.Click += new System.EventHandler(this.cheatsToolStripMenuItem_Click);
            // 
            // titlepic
            // 
            this.titlepic.Image = ((System.Drawing.Image)(resources.GetObject("titlepic.Image")));
            this.titlepic.Location = new System.Drawing.Point(103, 121);
            this.titlepic.Name = "titlepic";
            this.titlepic.Size = new System.Drawing.Size(594, 196);
            this.titlepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.titlepic.TabIndex = 1;
            this.titlepic.TabStop = false;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Eras Medium ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlay.Location = new System.Drawing.Point(150, 346);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(562, 55);
            this.lblPlay.TabIndex = 2;
            this.lblPlay.Text = "Please Choose Difficulty:";
            // 
            // NextLevelPic
            // 
            this.NextLevelPic.AutoSize = true;
            this.NextLevelPic.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLevelPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NextLevelPic.Location = new System.Drawing.Point(177, 303);
            this.NextLevelPic.Name = "NextLevelPic";
            this.NextLevelPic.Size = new System.Drawing.Size(422, 43);
            this.NextLevelPic.TabIndex = 3;
            this.NextLevelPic.Text = "Click To Play Next Level";
            this.NextLevelPic.Visible = false;
            this.NextLevelPic.Click += new System.EventHandler(this.NextLevelPic_Click);
            // 
            // HealthCounter
            // 
            this.HealthCounter.AutoSize = true;
            this.HealthCounter.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthCounter.ForeColor = System.Drawing.Color.Red;
            this.HealthCounter.Location = new System.Drawing.Point(654, 583);
            this.HealthCounter.Name = "HealthCounter";
            this.HealthCounter.Size = new System.Drawing.Size(0, 19);
            this.HealthCounter.TabIndex = 5;
            this.HealthCounter.Visible = false;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Easy.Location = new System.Drawing.Point(369, 401);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(83, 36);
            this.Easy.TabIndex = 6;
            this.Easy.Text = "Easy";
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Medium.Location = new System.Drawing.Point(343, 437);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(137, 36);
            this.Medium.TabIndex = 7;
            this.Medium.Text = "Medium";
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Realistic
            // 
            this.Realistic.AutoSize = true;
            this.Realistic.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Realistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Realistic.Location = new System.Drawing.Point(343, 473);
            this.Realistic.Name = "Realistic";
            this.Realistic.Size = new System.Drawing.Size(135, 36);
            this.Realistic.TabIndex = 8;
            this.Realistic.Text = "Realistic";
            this.Realistic.Click += new System.EventHandler(this.Realistic_Click);
            // 
            // LevelLBL
            // 
            this.LevelLBL.AutoSize = true;
            this.LevelLBL.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LevelLBL.Location = new System.Drawing.Point(26, 588);
            this.LevelLBL.Name = "LevelLBL";
            this.LevelLBL.Size = new System.Drawing.Size(0, 19);
            this.LevelLBL.TabIndex = 9;
            // 
            // Pistolpic
            // 
            this.Pistolpic.Image = ((System.Drawing.Image)(resources.GetObject("Pistolpic.Image")));
            this.Pistolpic.Location = new System.Drawing.Point(248, 583);
            this.Pistolpic.Name = "Pistolpic";
            this.Pistolpic.Size = new System.Drawing.Size(34, 21);
            this.Pistolpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pistolpic.TabIndex = 10;
            this.Pistolpic.TabStop = false;
            this.Pistolpic.Visible = false;
            this.Pistolpic.Click += new System.EventHandler(this.Pistolpic_Click);
            // 
            // RapidGunpic
            // 
            this.RapidGunpic.Image = ((System.Drawing.Image)(resources.GetObject("RapidGunpic.Image")));
            this.RapidGunpic.Location = new System.Drawing.Point(302, 583);
            this.RapidGunpic.Name = "RapidGunpic";
            this.RapidGunpic.Size = new System.Drawing.Size(41, 21);
            this.RapidGunpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RapidGunpic.TabIndex = 11;
            this.RapidGunpic.TabStop = false;
            this.RapidGunpic.Visible = false;
            this.RapidGunpic.Click += new System.EventHandler(this.RapidGunpic_Click);
            // 
            // Sniperpic
            // 
            this.Sniperpic.Image = ((System.Drawing.Image)(resources.GetObject("Sniperpic.Image")));
            this.Sniperpic.Location = new System.Drawing.Point(405, 578);
            this.Sniperpic.Name = "Sniperpic";
            this.Sniperpic.Size = new System.Drawing.Size(64, 25);
            this.Sniperpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Sniperpic.TabIndex = 12;
            this.Sniperpic.TabStop = false;
            this.Sniperpic.Visible = false;
            this.Sniperpic.Click += new System.EventHandler(this.Sniperpic_Click);
            // 
            // SuperBallpic
            // 
            this.SuperBallpic.Image = ((System.Drawing.Image)(resources.GetObject("SuperBallpic.Image")));
            this.SuperBallpic.Location = new System.Drawing.Point(349, 578);
            this.SuperBallpic.Name = "SuperBallpic";
            this.SuperBallpic.Size = new System.Drawing.Size(41, 26);
            this.SuperBallpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SuperBallpic.TabIndex = 13;
            this.SuperBallpic.TabStop = false;
            this.SuperBallpic.Visible = false;
            this.SuperBallpic.Click += new System.EventHandler(this.SuperBallpic_Click);
            // 
            // Stunpic
            // 
            this.Stunpic.Image = ((System.Drawing.Image)(resources.GetObject("Stunpic.Image")));
            this.Stunpic.Location = new System.Drawing.Point(485, 581);
            this.Stunpic.Name = "Stunpic";
            this.Stunpic.Size = new System.Drawing.Size(50, 22);
            this.Stunpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Stunpic.TabIndex = 14;
            this.Stunpic.TabStop = false;
            this.Stunpic.Visible = false;
            this.Stunpic.Click += new System.EventHandler(this.Stunpic_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSize = true;
            this.PauseButton.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PauseButton.Location = new System.Drawing.Point(145, 588);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(57, 19);
            this.PauseButton.TabIndex = 15;
            this.PauseButton.Text = "Pause";
            this.PauseButton.Visible = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Paused
            // 
            this.Paused.AutoSize = true;
            this.Paused.Font = new System.Drawing.Font("Eras Medium ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paused.ForeColor = System.Drawing.Color.Red;
            this.Paused.Location = new System.Drawing.Point(342, 263);
            this.Paused.Name = "Paused";
            this.Paused.Size = new System.Drawing.Size(154, 40);
            this.Paused.TabIndex = 16;
            this.Paused.Text = "PAUSED";
            this.Paused.Visible = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 616);
            this.Controls.Add(this.Paused);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.Stunpic);
            this.Controls.Add(this.SuperBallpic);
            this.Controls.Add(this.Sniperpic);
            this.Controls.Add(this.RapidGunpic);
            this.Controls.Add(this.Pistolpic);
            this.Controls.Add(this.LevelLBL);
            this.Controls.Add(this.Realistic);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.HealthCounter);
            this.Controls.Add(this.NextLevelPic);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.titlepic);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "mainform";
            this.Text = "Sharpshooter";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistolpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapidGunpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sniperpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperBallpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stunpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox titlepic;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label NextLevelPic;
        private System.Windows.Forms.Label HealthCounter;
        private System.Windows.Forms.Label Easy;
        private System.Windows.Forms.Label Medium;
        private System.Windows.Forms.Label Realistic;
        private System.Windows.Forms.Label LevelLBL;
        private System.Windows.Forms.PictureBox Pistolpic;
        private System.Windows.Forms.PictureBox RapidGunpic;
        private System.Windows.Forms.PictureBox Sniperpic;
        private System.Windows.Forms.PictureBox SuperBallpic;
        private System.Windows.Forms.PictureBox Stunpic;
        private System.Windows.Forms.Label PauseButton;
        private System.Windows.Forms.Label Paused;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
    }
}

