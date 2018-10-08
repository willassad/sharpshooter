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
    public class TankGun : Weapon
    {
        public TankGun(PointF location)
            : base("Images/TankGun.png", location)
        {
            this.bulletspeed = 15f;
            this.bulletstartdistance = 10f;
            this.firedelay = 600;

        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/SuperBall.png", personfiring, new PointF());
            c.damage = 10;
            return c;
        }

    }
}

