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
    public class Wall
    {
        public int left;
        public int top;
        public int width;
        public int height;
        Bitmap image;

        public Wall(String colour, int left, int top, int width, int height)
        {
            image = new Bitmap("Images/" + colour + "Box.png");
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
            mainform.walllist.Add(this);
        }

        public void Draw(Graphics g)
        {
            g.Transform = new Matrix();
            g.DrawImage(image, new Rectangle(left - mainform.viewoffset.X, top - mainform.viewoffset.Y, width, height));
        }

         public PointF pointnearestto(PointF p)
        {
            PointF nearestpoint = new PointF();
            if (this.left > p.X)
            {
                nearestpoint.X = this.left;
            }
            else if (this.left + this.width < p.X)
            {
                nearestpoint.X = this.left + this.width;
            }
            else
            {
                nearestpoint.X = p.X;
            }

            if (this.top > p.Y)
            {
                nearestpoint.Y = this.top;
            }
            else if (this.top + this.height < p.Y)
            {
                nearestpoint.Y = this.top + this.height;
            }
            else
            {
                nearestpoint.Y = p.Y;
            }

            return nearestpoint;
        }

        public PointF normalatnearestpoint(PointF p)
        {
            PointF nearestpoint = this.pointnearestto(p);
            PointF normal = new PointF();
            normal.X = p.X - nearestpoint.X;
            normal.Y = p.Y - nearestpoint.Y;
            if (normal.X == 0 && normal.Y == 0)
            {
                return normal;

            }
            float factor = 1f / (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);
            normal.X *= factor;
            normal.Y *= factor;
            return normal;
        }
       
    }
}
