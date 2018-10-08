using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace sharpshooter_dw
{
    public class Player:Soldier
    {
        public Player(PointF location):base("Images/Player.png", location)
        {
            this.hp = mainform.difficulty;
            this.currentweapon = new Pistol(this.location);
        }

        public void KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                turndirc = 0.5f;
            }
            if (e.KeyCode == Keys.Right)
            {
                turndirc = -0.5f;
            }
            if (e.KeyCode == Keys.Up)
            {
                walkdirc = 1;
            }
            if (e.KeyCode == Keys.Down)
            {
                walkdirc = -1;
            }
            if (e.KeyCode == Keys.Space)
            {
                isfiring = true;
            }
            if (e.KeyCode == Keys.A && mainform.pickpistol)
            {
                mainform.Player1.currentweapon = new Pistol(this.location);
            }
            if (e.KeyCode == Keys.S && mainform.pickrapidgun)
            {
                mainform.Player1.currentweapon = new RapidGun(this.location);
            }
            if (e.KeyCode == Keys.D && mainform.picksuperball)
            {
                mainform.Player1.currentweapon = new SuperBallLauncher(this.location);
            }
            if (e.KeyCode == Keys.F && mainform.picksniper)
            {
                mainform.Player1.currentweapon = new SniperGun(this.location);
            }

            if (e.KeyCode == Keys.G && mainform.pickstun)
            {
                mainform.Player1.currentweapon = new StunGun(this.location);
            }
        }
        public void KeyUp(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                turndirc = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                turndirc = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                walkdirc = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                walkdirc = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                isfiring = false;
            }
        }
    }
}
