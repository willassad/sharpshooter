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
    public class Picture
    {
        public Bitmap bitmap;
        public PointF location;
        public float angle = 0f;
        public PointF offset;
        public int frame = 0;
        public int framecount;
        public int timeperframe;
        public int animationcounter = 0;

        public Picture(string filename, PointF location, int frames, int fliptime)
        {
            bitmap = new Bitmap(filename);
            this.location = location;
            this.framecount = frames;
            this.timeperframe = fliptime;
            offset = new PointF(bitmap.Width / 2f, bitmap.Height/ framecount / 2f);
        }

        public void Draw(Graphics g)
        {
            Matrix r = new Matrix();
            Point drawLocation = new Point((int)(location.X - offset.X), (int)(location.Y - offset.Y));
            r.RotateAt(-angle, location);
            g.Transform = r;
           g.DrawImage(bitmap, new Rectangle(drawLocation.X, drawLocation.Y, bitmap.Width, bitmap.Height / this.framecount), new Rectangle(0,this.frame * bitmap.Height / this.framecount, bitmap.Width,bitmap.Height / this.framecount),GraphicsUnit.Pixel);
        }
        public void Update(int time)
        {
            animationcounter += time;
            if (animationcounter >= this.timeperframe)
            {
                this.frame++;
                if (this.frame >= this.framecount)
                {
                    frame = 0;
                }
                animationcounter = 0;
            }
        }
    }
}
