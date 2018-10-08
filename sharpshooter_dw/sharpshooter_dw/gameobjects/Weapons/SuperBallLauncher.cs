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
    public class SuperBallLauncher : Weapon
    {
        public SuperBallLauncher(PointF location)
            : base("Images/SuperBallLauncher.png", location)
        {
            this.bulletspeed = 15f;
            this.bulletstartdistance = 20f;
            this.firedelay = 599;
           
        }

        public override Bullet createbullet(Soldier personfiring)
        {
            Bullet c = new Bullet("Images/SuperBall.png", personfiring, new PointF());
             c.damage = 10;
             return c; 
        }

    }
}
