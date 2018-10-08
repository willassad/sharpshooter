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
    public class EnemySoldier3 : Soldier
    {
        int directionchangecount = 0;
        int nextdirectionchange = 0;

        public EnemySoldier3(PointF location)
            : base("Images/Enemy3.png", location)
        {
            mainform.enemylist.Add(this);
            isfiring = true;
            movespeed = 2;
            walkdirc = 1;
            this.hp = 20;
            Random r = new Random((int)location.X);
            nextdirectionchange = r.Next(500) + 2000;
            this.currentweapon = new SuperBallLauncher(this.location);
        }

        public override void Update(int time)
        {
            base.Update(time);
            directionchangecount += time;
            if (directionchangecount >= nextdirectionchange)
            {
                Random r = new Random();
                facingAngle = r.Next(360);
                directionchangecount = 0;
                nextdirectionchange = r.Next(500) + 2000;
            }
        }
    }
}


