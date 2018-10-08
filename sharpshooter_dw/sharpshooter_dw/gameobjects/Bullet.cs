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
    public class Bullet
    {
        public Picture pic;
        public PointF location;
        public PointF velocity;
        public float life = 1.0f;
        public int radius;
        public Soldier parent;
        public int damage = 1;
        
        public Bullet(string image, Soldier s, PointF location)
        {
            pic = new Picture(image, location, 4, 25);
            this.location = location;
            radius = pic.bitmap.Width / 2;
            velocity = new PointF();
            this.parent = s;
            mainform.bulletlist.Add(this);
        }

        public virtual void Draw(Graphics g)
        {
            pic.location.X = location.X - mainform.viewoffset.X;
            pic.location.Y = location.Y - mainform.viewoffset.Y;
            pic.Draw(g);
        }
        public void Update(int time)
        {
            Move();
            pic.Update(time);
            life -= (float)time / 1000f;

            if (life <= 0)
            {
                mainform.bulletlist.Remove(this);
            }
            foreach (Wall w in mainform.walllist)
            {
                if (this.istouchingwall(w))
                {
                    this.backupposition();
                    PointF normal = w.normalatnearestpoint(this.location);
                    this.bouncefrom(normal);

                }
            }
            if (parent == mainform.Player1)
            {
                for (int i = 0; i < mainform.enemylist.Count; i++)
                {
                    if (this.istouching(mainform.enemylist[i]))
                    {
                        mainform.enemylist[i].takedamage(this.damage);
                        if (this.damage == 2 && mainform.enemylist[i].CharStun && mainform.enemylist[i].currentweapon.firedelay != 400)
                        {
                            mainform.enemylist[i].CharFullStun = true;
                        }
                        else if (this.damage == 2 && mainform.enemylist[i].currentweapon.firedelay != 400)
                        {
                            mainform.enemylist[i].CharStun = true;
                        }
                        mainform.bulletlist.Remove(this);
                    }
                }
            }

            if (this.istouching(mainform.Player1) && !mainform.Player1.killed && !mainform.invincible)
            {
                mainform.Player1.takedamage(this.damage);
                mainform.bulletlist.Remove(this);
            }
        }



        public void Move()
        {
            location.X += velocity.X;
            location.Y += velocity.Y;
        }
        public bool istouching(Soldier s)
        {
            double distance = Math.Sqrt((s.location.X - this.location.X) * (s.location.X - this.location.X) + (s.location.Y - this.location.Y) * (s.location.Y - this.location.Y));
            return distance < this.radius + s.radius;
        }
        public bool istouchingwall(Wall w)
        {
            PointF nearestpoint = w.pointnearestto(this.location);
            double distance = Math.Sqrt((nearestpoint.X - location.X) * (nearestpoint.X - location.X) + (nearestpoint.Y - location.Y) * (nearestpoint.Y - location.Y));
            if (distance < this.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void backupposition()
        {
            this.location.X -= this.velocity.X;
            this.location.Y -= this.velocity.Y;
        }

        public void bouncefrom(PointF normal)
        {
            PointF r;
            float b = (velocity.X * normal.X + velocity.Y * normal.Y);
            b *= 2;
            r = new PointF(this.velocity.X - normal.X * b, this.velocity.Y - normal.Y * b);
            this.velocity.X = r.X;
            this.velocity.Y = r.Y;
        }
        
    }
}
