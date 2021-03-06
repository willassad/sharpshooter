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
    public class StunGun : Weapon
    {
        public StunGun(PointF location)
            : base("Images/StunGun.png", location)
        {
            this.bulletspeed = 15f;
            this.bulletstartdistance = 10f;
            this.firedelay = 100;
            this.stun = true;
            this.fullstun = false;
        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/Bullet2.png", personfiring, new PointF());
            c.damage = 2;
            return c;
        }

    }
}

