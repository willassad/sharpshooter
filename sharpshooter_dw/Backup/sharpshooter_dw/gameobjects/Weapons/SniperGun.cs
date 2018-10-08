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
    public class SniperGun:Weapon
    {
        public SniperGun(PointF location):base("Images/SniperGun.png", location)
        {
            this.bulletspeed = 15f;
            this.bulletstartdistance = 10f;
            this.firedelay = 600;
        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/SniperBullet.png", personfiring, new PointF());
            c.damage = 5;
            return c; 
        }
    }
}
