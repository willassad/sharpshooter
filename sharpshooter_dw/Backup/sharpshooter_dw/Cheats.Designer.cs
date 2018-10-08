namespace sharpshooter_dw
{
    partial class Cheats
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
            this.label1 = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Label();
            this.CheatInput = new System.Windows.Forms.TextBox();
            this.EnterCheat = new System.Windows.Forms.Label();
            this.Invincibility = new System.Windows.Forms.Label();
            this.UnlockWeapons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cheats";
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Location = new System.Drawing.Point(31, 53);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(191, 13);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Please enter a code to unlock a cheat.";
            // 
            // CheatInput
            // 
            this.CheatInput.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheatInput.Location = new System.Drawing.Point(34, 86);
            this.CheatInput.Name = "CheatInput";
            this.CheatInput.Size = new System.Drawing.Size(188, 20);
            this.CheatInput.TabIndex = 2;
            this.CheatInput.TextChanged += new System.EventHandler(this.CheatInput_TextChanged);
            // 
            // EnterCheat
            // 
            this.EnterCheat.AutoSize = true;
            this.EnterCheat.BackColor = System.Drawing.Color.Black;
            this.EnterCheat.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCheat.ForeColor = System.Drawing.Color.White;
            this.EnterCheat.Location = new System.Drawing.Point(50, 120);
            this.EnterCheat.Name = "EnterCheat";
            this.EnterCheat.Size = new System.Drawing.Size(151, 15);
            this.EnterCheat.TabIndex = 3;
            this.EnterCheat.Text = "Click Here to Enter Cheat";
            this.EnterCheat.Click += new System.EventHandler(this.EnterCheat_Click);
            // 
            // Invincibility
            // 
            this.Invincibility.AutoSize = true;
            this.Invincibility.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invincibility.Location = new System.Drawing.Point(34, 165);
            this.Invincibility.Name = "Invincibility";
            this.Invincibility.Size = new System.Drawing.Size(84, 15);
            this.Invincibility.TabIndex = 4;
            this.Invincibility.Text = "Invincibility";
            this.Invincibility.Visible = false;
            // 
            // UnlockWeapons
            // 
            this.UnlockWeapons.AutoSize = true;
            this.UnlockWeapons.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockWeapons.Location = new System.Drawing.Point(34, 199);
            this.UnlockWeapons.Name = "UnlockWeapons";
            this.UnlockWeapons.Size = new System.Drawing.Size(142, 15);
            this.UnlockWeapons.TabIndex = 5;
            this.UnlockWeapons.Text = "Unlock All Weapons";
            this.UnlockWeapons.Visible = false;
            // 
            // Cheats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.UnlockWeapons);
            this.Controls.Add(this.Invincibility);
            this.Controls.Add(this.EnterCheat);
            this.Controls.Add(this.CheatInput);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Cheats";
            this.Text = "Cheats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.TextBox CheatInput;
        private System.Windows.Forms.Label EnterCheat;
        private System.Windows.Forms.Label Invincibility;
        private System.Windows.Forms.Label UnlockWeapons;

    }
}