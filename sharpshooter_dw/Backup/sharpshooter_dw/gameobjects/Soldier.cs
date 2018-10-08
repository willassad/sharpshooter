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
    public class Soldier
    {
        public Picture pic;
        public PointF location;
        public float facingAngle = 0;
        public float turndirc = 0;
        public int walkdirc = 0;
        public PointF velocity;
        public int movespeed = 10;
        public bool isfiring = false;
        public int radius;
        public int hp = 5;
        public bool killed = false;
        public bool hitflicker = false;
        public int hitflickercount = 0;
        public Weapon currentweapon;
        public bool CharStun = false;
        public bool CharFullStun = false;

        public Soldier(String image, PointF location)
        {
            pic = new Picture(image, location, 4, 60);
            this.location = location;
            velocity = new PointF();
            Random r = new Random((int)DateTime.Now.Ticks);
            facingAngle = r.Next(360);
            radius = pic.bitmap.Width / 2;
            CharStun = false;
            CharFullStun = false;
        }

        public void Draw(Graphics g)
        {
            if (this.killed)
            {
                return;
            }
            if (!this.CharFullStun)
            {
                pic.angle = facingAngle;
            }
            if (!hitflicker)
            {
                pic.location.X = location.X- mainform.viewoffset.X;
                pic.location.Y = location.Y - mainform.viewoffset.Y;
                pic.Draw(g);
                currentweapon.Draw(g);
            }
        }
        public virtual void Update(int time)
        {
            if (hp <= 0)
            {
                killed = true;
                Explosion e = new Explosion(this.location);
                mainform.sound.playsound("Sounds/Explosion.wav", this.location);
                mainform.enemylist.Remove(this);
                return;
            }
            if (CharFullStun)
            {
                return;
            }
            if (hitflickercount > 0)
            {
                hitflickercount--;
                hitflicker = !hitflicker;
            }
            else 
            {
                hitflicker = false;
            }
            facingAngle += ((float)(time)) * turndirc;
            velocity.X = (float)Math.Cos(facingAngle / 180f * Math.PI) * walkdirc * movespeed;
            velocity.Y = (float)-Math.Sin(facingAngle / 180f * Math.PI) * walkdirc * movespeed;
            Move();
            if (velocity.X != 0 || velocity.Y != 0)
            {
                pic.Update(time);
            }
            foreach (Wall w in mainform.walllist)
            {
                PointF touchpoint = new PointF();
                if (this.istouchingwall(w, ref touchpoint))
                {
                    pushfrom(touchpoint);
                }
            }
            if (isfiring)
            {
                currentweapon.fire(this);
            }
            this.updateweapon(time);
        }

        public void updateweapon(int time)
        {
            float xoffset = (float)Math.Cos(this.facingAngle / 180f * Math.PI) * 32f;
            float yoffset = (float)-Math.Sin(this.facingAngle / 180f * Math.PI) * 32f;
            currentweapon.location.X = location.X + xoffset;
            currentweapon.location.Y = location.Y + yoffset;
            currentweapon.facingangle = this.facingAngle;
            currentweapon.Update(time);
        }


        public void Move()
        {
            if (!CharStun)
            {
                location.X += velocity.X;
                location.Y += velocity.Y;
            }
        }
        

        public void takedamage(int damage)
        {
            hp -= damage;
            hitflickercount = 4;
        }

        public bool istouchingwall(Wall w, ref PointF touchpoint)
        {
            PointF nearestpoint = w.pointnearestto(this.location);
            double distance = Math.Sqrt((nearestpoint.X - location.X) * (nearestpoint.X - location.X) + (nearestpoint.Y - location.Y) * (nearestpoint.Y - location.Y));
            if (distance < this.radius)
            {
                touchpoint = nearestpoint;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pushfrom(PointF p)
        {
            float actualdistance = (float) Math.Sqrt((p.X - this.location.X) * (p.X - this.location.X) + (p.Y - this.location.Y) * (p.Y - this.location.Y));
            if (actualdistance == 0)
            {
                return;
            }
            float desireddistance = this.radius + 1;
            float proportion = desireddistance / actualdistance;
            PointF move = new PointF(this.location.X - p.X, this.location.Y -p.Y);
            move.X *= proportion;
            move.Y *= proportion;
            this.location.X = p.X + move.X;
            this.location.Y = p.Y +move.Y;
        }
    }
}
