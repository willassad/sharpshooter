namespace sharpshooter_dw
{
    partial class Instructions
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
            this.HowToPlay = new System.Windows.Forms.Label();
            this.Movement = new System.Windows.Forms.Label();
            this.Firing = new System.Windows.Forms.Label();
            this.WeaponSelection = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HowToPlay
            // 
            this.HowToPlay.AutoSize = true;
            this.HowToPlay.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.Location = new System.Drawing.Point(13, 13);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(131, 22);
            this.HowToPlay.TabIndex = 0;
            this.HowToPlay.Text = "How To Play:";
            // 
            // Movement
            // 
            this.Movement.AutoSize = true;
            this.Movement.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movement.Location = new System.Drawing.Point(32, 66);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(232, 14);
            this.Movement.TabIndex = 1;
            this.Movement.Text = "Move your player by using the Arrow Keys.";
            // 
            // Firing
            // 
            this.Firing.AutoSize = true;
            this.Firing.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firing.Location = new System.Drawing.Point(32, 98);
            this.Firing.Name = "Firing";
            this.Firing.Size = new System.Drawing.Size(217, 14);
            this.Firing.TabIndex = 2;
            this.Firing.Text = "To fire your weapon. iuse the Space Bar.";
            // 
            // WeaponSelection
            // 
            this.WeaponSelection.AutoSize = true;
            this.WeaponSelection.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponSelection.Location = new System.Drawing.Point(32, 127);
            this.WeaponSelection.Name = "WeaponSelection";
            this.WeaponSelection.Size = new System.Drawing.Size(250, 42);
            this.WeaponSelection.TabIndex = 3;
            this.WeaponSelection.Text = "You can change your weapons by using the\r\nA, S, D, F, and G keys; or by clicking " +
                "the image\r\nof the weapon that is onscreen.";
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.Font = new System.Drawing.Font("Eras Medium ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(32, 185);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(215, 28);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Click \"Pause\" to pause the game. Click it\r\nagain to resume.";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.WeaponSelection);
            this.Controls.Add(this.Firing);
            this.Controls.Add(this.Movement);
            this.Controls.Add(this.HowToPlay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HowToPlay;
        private System.Windows.Forms.Label Movement;
        private System.Windows.Forms.Label Firing;
        private System.Windows.Forms.Label WeaponSelection;
        private System.Windows.Forms.Label Pause;
    }
}