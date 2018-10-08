using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sharpshooter_dw
{
    public partial class mainform : Form
    {
        public static Player Player1;
        public static List<Bullet> bulletlist;
        public static List<Soldier> enemylist;
        public static List<Wall> walllist;
        public static List<HealthPack> healthlist;
        public static List<Weapon> weaponlist;
        public Picture gameoverscreen;
        public Picture victoryscreen;
        public static List<Explosion> explosionlist;
        public static Point viewoffset;
        public static Sounds sound;
        public int levelnum = 1;
        public static int difficulty = 50;
        public static bool pickpistol = true;
        public static bool pickrapidgun = false;
        public static bool picksuperball = false;
        public static bool picksniper = false;
        public static bool pickstun = false;
        public bool showboss = false;
        public static bool invincible = false;
        public static bool allweapons = false;
        public static String cheatcode = "";
        public Instructions instructionsform = new Instructions();
        public Cheats cheatsform = new Cheats();
        public Bitmap background = new Bitmap("Images/Ground.png");
        public Picture playagain;
   
        Graphics windowsgraphics;
        Graphics onscreengraphics;
        Bitmap screen;

        public mainform()
        {
            InitializeComponent();
            windowsgraphics = this.CreateGraphics();
            screen = new Bitmap(this.Width, this.Height-75);
            onscreengraphics = Graphics.FromImage(screen);
            this.Paint += new PaintEventHandler(DrawGame);
            //sound = new Sounds(this);
            Init();
        }

        private void Init()
        {
            gameoverscreen = new Picture("Images/GameOver.png", new PointF(this.Width / 2, this.Height / 3), 1, 1);
            victoryscreen = new Picture("Images/Victory.png", new PointF(this.Width / 2, this.Height / 3), 1, 1);
            playagain = new Picture("Images/playagain.png", new PointF(this.Width / 2, this.Height / 2), 1, 1);
            Level.Createlevel();
            levelnum = 1;
            pickpistol = true;
            pickrapidgun = false;
            picksuperball = false;
            picksniper = false;
            pickstun = false;
            RapidGunpic.Visible = false;
            SuperBallpic.Visible = false;
            Stunpic.Visible = false;
            Sniperpic.Visible = false;
            HealthCounter.Visible = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Player1.KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Player1.KeyUp);
            //sound.playbgm("Sounds/ShadowRock.mp3");
           
        }

        public void DrawGame(Object sender, PaintEventArgs e)
        {
            if (!gametimer.Enabled)
            {
                return;
            }
            onscreengraphics.Clear(Color.Black);
            onscreengraphics.DrawImage(background, new Rectangle(- 1224 - viewoffset.X, -1224 - viewoffset.Y, 1224, 1224));
            onscreengraphics.DrawImage(background, new Rectangle(- 1224 - viewoffset.X, - viewoffset.Y, 1224, 1224));
            onscreengraphics.DrawImage(background, new Rectangle(- viewoffset.X, -1224 - viewoffset.Y, 1224, 1224));
            onscreengraphics.DrawImage(background, new Rectangle(-viewoffset.X, -viewoffset.Y, 1224, 1224));
            Player1.Draw(onscreengraphics);
            foreach (Bullet b in bulletlist)
            {
                b.Draw(onscreengraphics);
            }
            foreach (Soldier s in enemylist)
            {
                s.Draw(onscreengraphics);
            }
            foreach (Wall w in walllist)
            {
                w.Draw(onscreengraphics);
            }
            if (Player1.killed)
            {
                gameoverscreen.Draw(onscreengraphics);
                allweapons = false;
                pickrapidgun = false;
                RapidGunpic.Visible = false;
                picksuperball =false;
                SuperBallpic.Visible = false;
                picksniper = false;
                Sniperpic.Visible = false;
                pickstun = false;
                Stunpic.Visible = false;
                playagain.Draw(onscreengraphics);
            }

            if (enemylist.Count == 0 && levelnum == 3)
            {
                if (showboss)
                {
                    victoryscreen.Draw(onscreengraphics);
                    invincible= false;
                    allweapons = false;
                    pickrapidgun = false;
                    RapidGunpic.Visible = false;
                    picksuperball = false;
                    SuperBallpic.Visible = false;
                    picksniper = false;
                    Sniperpic.Visible = false;
                    pickstun = false;
                    Stunpic.Visible = false;
                    playagain.Draw(onscreengraphics);
                }
                else
                {
                    showboss = true;
                    Level.CreateBoss();
                    Player1.location.X = 0;
                    Player1.location.Y = -2000;
                }
            }
            else if (enemylist.Count == 0 && levelnum == 2)
            {
                gametimer.Enabled = false;
                NextLevelPic.Visible = true;
                levelnum = levelnum + 1;
                Player1.location.X = -150;
                Player1.location.Y = -2250;
                Player1.hp += 10;
                Level.Createlevel3();
            }
            else if (enemylist.Count == 0 && levelnum == 1)
            {
                gametimer.Enabled = false;
                NextLevelPic.Visible = true;
                levelnum = levelnum + 1;
                Player1.hp += 10;
                Level.Createlevel2();
            }
            foreach (Explosion ex in explosionlist)
            {
                ex.Draw(onscreengraphics);
            }
            foreach (Weapon w in weaponlist)
            {
                w.Draw(onscreengraphics);
            }
            foreach (HealthPack h in healthlist)
            {
                h.Draw(onscreengraphics);
            }
            windowsgraphics.DrawImage(screen, new Point(0, 0));
        
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            Player1.Update(gametimer.Interval);
            Pistolpic.Visible = true;
            PauseButton.Visible = true;
            if (allweapons)
            {
                pickrapidgun = true;
                RapidGunpic.Visible = true;
                picksuperball = true;
                SuperBallpic.Visible = true;
                picksniper = true;
                Sniperpic.Visible = true;
                pickstun = true;
                Stunpic.Visible = true;
            }
            if (Player1.currentweapon.firedelay == 50)
            {
                pickrapidgun = true;
                RapidGunpic.Visible = true;
            }

            if (Player1.currentweapon.firedelay == 599)
            {
                picksuperball = true;
                SuperBallpic.Visible = true;
            }

            if (Player1.currentweapon.firedelay == 600)
            {
                picksniper = true;
                Sniperpic.Visible = true;
            }
            if (Player1.currentweapon.firedelay == 100)
            {
                pickstun = true;
                Stunpic.Visible = true;
            }

            for (int i = 0; i < explosionlist.Count; i++)
            {
                explosionlist[i].Update(gametimer.Interval);
            }
            for (int i = 0; i < bulletlist.Count; i++)
            {
                bulletlist[i].Update(gametimer.Interval);
            }
            for (int i = 0; i < enemylist.Count; i++)
            {
                enemylist[i].Update(gametimer.Interval);
            }
            for (int i = 0; i < weaponlist.Count; i++)
            {
                weaponlist[i].Update(gametimer.Interval);
            }
            for (int i = 0; i < healthlist.Count; i++)
            {
                if (healthlist[i].onground)
                {
                    healthlist[i].Update(gametimer.Interval);
                }
                else
                {
                    healthlist.RemoveAt(i);
                }
            }
            HealthCounter.Text = "Health: " + Player1.hp.ToString();
            LevelLBL.Text = "Level: " + levelnum.ToString();
            viewoffset.X = (int)Player1.location.X - this.Width / 2;
            viewoffset.Y = (int)Player1.location.Y - this.Height / 2;
            OnPaint(new PaintEventArgs(windowsgraphics, new Rectangle(0, 0, this.Width, this.Height)));
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextLevelPic_Click(object sender, EventArgs e)
        {
            NextLevelPic.Visible = false;
            gametimer.Enabled = true;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            difficulty = 50;
            Init();
            titlepic.Visible = false;
            lblPlay.Visible = false;
            Easy.Visible = false;
            Medium.Visible = false;
            Realistic.Visible = false;
            gametimer.Enabled = true;
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            difficulty = 35;
            Init();
            titlepic.Visible = false;
            lblPlay.Visible = false;
            Easy.Visible = false;
            Medium.Visible = false;
            Realistic.Visible = false;
            gametimer.Enabled = true;
        }

        private void Realistic_Click(object sender, EventArgs e)
        {
            difficulty = 20;
            Init();
            titlepic.Visible = false;
            lblPlay.Visible = false;
            Easy.Visible = false;
            Medium.Visible = false;
            Realistic.Visible = false;
            gametimer.Enabled = true;
        }

        private void Pistolpic_Click(object sender, EventArgs e)
        {
            Player1.currentweapon = new Pistol(Player1.location);
        }

        private void RapidGunpic_Click(object sender, EventArgs e)
        {
            Player1.currentweapon = new RapidGun(Player1.location);
        }

        private void Sniperpic_Click(object sender, EventArgs e)
        {
            Player1.currentweapon = new SniperGun(Player1.location);
        }

        private void SuperBallpic_Click(object sender, EventArgs e)
        {
            Player1.currentweapon = new SuperBallLauncher(Player1.location);
        }

        private void Stunpic_Click(object sender, EventArgs e)
        {
            Player1.currentweapon = new StunGun(Player1.location);
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (gametimer.Enabled)
            {
                gametimer.Enabled = false;
                Paused.Visible = true;
            }
            else
            {
                Paused.Visible = false;
                gametimer.Enabled = true;
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!instructionsform.Visible)
            {
                instructionsform = new Instructions();
            }
            instructionsform.Show();
            instructionsform.BringToFront();
        }

        private void cheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cheatsform.Visible)
            {
                cheatsform = new Cheats();
            }
            cheatsform.Show();
            cheatsform.BringToFront();
        }

    
    }
}