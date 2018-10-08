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
    public class RapidGun : Weapon
    {
        public RapidGun(PointF location)
            : base("Images/RapidGun.png", location)
        {
            this.bulletspeed = 15f;
            this.bulletstartdistance = 10f;
            this.firedelay = 50;
        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/Bullet3.png", personfiring, new PointF());
            c.damage = 3;
            return c; 
        }

    }
}
