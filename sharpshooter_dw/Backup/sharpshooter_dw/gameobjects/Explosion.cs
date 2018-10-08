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
    public class Explosion
    {
        public PointF location;
        public Picture pic;
        public int life = 240;

        public Explosion(PointF location)
        {
            pic = new Picture("Images/Explode.png", location, 6, 40);
            this.location = location;
            mainform.explosionlist.Add(this);
        }
        public virtual void Draw(Graphics g)
        {
            pic.location.X = location.X - mainform.viewoffset.X;
            pic.location.Y = location.Y - mainform.viewoffset.Y;
            pic.Draw(g);
        }
        public void Update(int time)
        {
            life -= time;
            if (life <= 0)
            {
                mainform.explosionlist.Remove(this);
                return;
            }
            pic.Update(time);
        }
    }
}
