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
    public class Pistol:Weapon
    {
        public Pistol(PointF location):base("Images/Pistol.png", location)
        {
            this.bulletspeed = 30f;
            this.bulletstartdistance = 10f;
            this.firedelay = 300;
        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/Bullet1.png", personfiring, new PointF());
            c.damage = 3;
            return c; 
        }

    }
}
