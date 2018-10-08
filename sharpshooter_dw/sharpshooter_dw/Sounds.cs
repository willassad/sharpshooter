using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;
using Microsoft.DirectX.AudioVideoPlayback;

namespace sharpshooter_dw
{
    public class Sounds
    {
        public Device dsound;
        public BufferDescription bufferdescription;
        public Audio bgm;
        public bool bgmplaying = false;
        public List<SecondaryBuffer> soundbuffers = new List<SecondaryBuffer>();

        public Sounds(mainform MainForm)
        {
            dsound = new Device();
            dsound.SetCooperativeLevel(MainForm.Handle, CooperativeLevel.Priority);
            bufferdescription = new BufferDescription();
            bufferdescription.ControlVolume = true;
        }

        public void playsound(string Filename, PointF position)
        {
            for (int i = 0; i < soundbuffers.Count; i++)
            {
                if (!soundbuffers[i].Status.Playing)
                {
                    soundbuffers[i].Dispose();
                    soundbuffers.RemoveAt(i);
                }
            }
            SecondaryBuffer sound = new SecondaryBuffer(Filename, bufferdescription, dsound);
            soundbuffers.Add(sound);
            sound.Volume -= (int)(Math.Abs(mainform.Player1.location.X - position.X) + Math.Abs(mainform.Player1.location.Y - position.Y)) * 2;
            sound.Play(0, BufferPlayFlags.Default);

        }

        public void playbgm(string Filename)
        {
            if (bgmplaying)
            {
                return;
            }
            bgm = new Audio(Filename);
            bgm.Play();
            bgm.Ending += new EventHandler(bgm_Ending);
            bgmplaying = true;
        }

        public void bgm_Ending(object sender, EventArgs e)
        {
            bgm.SeekCurrentPosition(0.0, SeekPositionFlags.AbsolutePositioning);
        }

        public void stopbgm()
        {
            bgmplaying = false;
            bgm.Stop();
        }
    }
}
