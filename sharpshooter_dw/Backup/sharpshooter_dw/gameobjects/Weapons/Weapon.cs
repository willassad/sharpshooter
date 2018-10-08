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
    public abstract class Weapon
    {
        public Picture pic;
        public PointF location;
        public float bulletspeed;
        public float bulletstartdistance;
        public float facingangle;
        public int timesincelastshot = 0;
        public int firedelay;
        public bool onground = false;
        public int radius;
        public bool stun = false;
        public bool fullstun = false;
        

        public Weapon(string image, PointF location)
        {
            this.pic = new Picture(image, location, 1, 1);
            this.radius = pic.bitmap.Width / 2;
            this.location = location;
        }

        public void Draw(Graphics g)
        {
            pic.angle = facingangle;
            pic.location.X = location.X - mainform.viewoffset.X;
            pic.location.Y = location.Y - mainform.viewoffset.Y;
            pic.Draw(g);
        }

        public void fire(Soldier personfiring)
        {
            if (timesincelastshot < firedelay)
            {
                return;
            }
            timesincelastshot = 0;
            float xcomponent = (float)Math.Cos(facingangle / 180f * Math.PI);
            float ycomponent = (float)-Math.Sin(facingangle / 180f * Math.PI);
            Bullet bullet = createbullet(personfiring);
            bullet.location.X = this.location.X + xcomponent * bulletstartdistance;
            bullet.location.Y = this.location.Y + ycomponent * bulletstartdistance;
            bullet.velocity.X = xcomponent * bulletspeed;
            bullet.velocity.Y = ycomponent * bulletspeed;
        }

        public void Update(int time)
        {
            timesincelastshot += time;
            if (this.onground && this.istouching(mainform.Player1))
            {
                this.onground = false;
                mainform.weaponlist.Remove(this);
                mainform.Player1.currentweapon = this;
            }
        }

        public bool istouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) + (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));
            return distance < this.radius + s.radius;
        }

        public abstract Bullet createbullet(Soldier personfiring);
    }
}
