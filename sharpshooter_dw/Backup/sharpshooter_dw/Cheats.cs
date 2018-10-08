using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sharpshooter_dw
{
    public partial class Cheats : Form
    {
        public Cheats()
        {
            InitializeComponent();
        }

        private void CheatInput_TextChanged(object sender, EventArgs e)
        {
            mainform.cheatcode = CheatInput.Text;
        }

        private void EnterCheat_Click(object sender, EventArgs e)
        {
            if (mainform.cheatcode == "invincibility" && !mainform.invincible)
            {
                mainform.invincible = true;
                Invincibility.Visible = true;
            }
            else if (mainform.cheatcode == "invincibility" && mainform.invincible)
            {
                mainform.invincible = false;
                Invincibility.Visible = false;
            }
            if (mainform.cheatcode=="weapons")
            {
                mainform.allweapons = true;
                UnlockWeapons.Visible = true;
            }
        }
    }
}