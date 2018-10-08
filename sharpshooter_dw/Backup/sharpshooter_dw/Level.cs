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
    public class Level
    {
        public static void initializelists()
        {
            mainform.bulletlist = new List<Bullet>();
            mainform.enemylist = new List<Soldier>();
            mainform.walllist = new List<Wall>();
            mainform.explosionlist = new List<Explosion>();
            mainform.weaponlist = new List<Weapon>();
            mainform.healthlist = new List<HealthPack>();
        }
        public static void createborders(int topX, int topY, int width, int height)
        {
            Wall bordertop = new Wall("Green", topX - 80, topY-80, width + 80, 80);
            Wall borderleft = new Wall("Green", topX - 80, topY, 80, height + 80);
            Wall borderbottom = new Wall("Green", topX, topY + height, width + 80, 80);
            Wall borderright = new Wall("Green", topX + width, topY - 80, 80, width + 80);
        }
        public static void createwalls()
        {
            // RIGHT SIDE
            Wall wall1 = new Wall("Green", 350, -380, 450, 75);
            Wall wall2 = new Wall("Green", 350, -800, 75, 350);
            Wall wall3 = new Wall("Green", 350, -200, 75, 900);
            Wall wall4 = new Wall("Green", 500, 15, 300, 75);
            Wall wall5 = new Wall("Green", 500, 315, 300, 75);
            Wall wall6 = new Wall("Green", 500, 520, 302, 200);
            
            //MIDDLE
            Wall wall7 = new Wall("Green", -80, -800, 200, 300);
            Wall wall8 = new Wall("Green", -175, -420, 400, 75);
            Wall wall9 = new Wall("Green", -175, 320, 400, 75);
            Wall wall10 = new Wall("Green", -80, 500, 200, 300);

            // LEFT SIDE
            Wall wall11 = new Wall("Green", -800, -380, 525, 75);
            Wall wall12 = new Wall("Green", -350, -800, 75, 350);
            Wall wall13 = new Wall("Green", -350, -200, 75, 900);
            Wall wall14 = new Wall("Green", -800, 15, 300, 75);
            Wall wall15 = new Wall("Green", -800, 315, 300, 75);
            Wall wall16 = new Wall("Green", -800, 530, 302, 200);

            // LEVEL 3
            Wall wall17 = new Wall("Blue", -550, -2400, 1105, 75);
            Wall wall18 = new Wall("Blue", -550, -2370, 75, 770);
            Wall wall19 = new Wall("Blue", -550, -1630, 1075, 75);
            Wall wall20 = new Wall("Blue", 475, -2400, 75, 820);

            Wall wall21 = new Wall("Green", -100, -2200, 30, 200);
            Wall wall22 = new Wall("Green", -270, -2005, 200, 30);
            Wall wall23 = new Wall("Green", 100, -2200, 30, 200);
            Wall wall24 = new Wall("Green", 100, -2005, 200, 30);
            
        }
        public static void Createenemies()
        {
            // RAPID GUN HALL
            EnemySoldier2 e1 = new EnemySoldier2(new PointF(770, -200));
            //RAPID GUN ROOM
            EnemySoldier e2 = new EnemySoldier(new PointF(750, 400));
            // SUPER BALL LAUNCHER
            EnemySoldier2 e3 = new EnemySoldier2(new PointF(-650, -650));
            // PISTOL AREA
            EnemySoldier2 e4 = new EnemySoldier2(new PointF(100, 300));
            // PISTOL AREA
            EnemySoldier2 e5 = new EnemySoldier2(new PointF(200, 375));
            // PISTOL AREA
            Tank t1 = new Tank(new PointF(150, 275));
            // PISTOL AREA
            EnemySoldier e6 = new EnemySoldier(new PointF(0, 0));
            // SNIPER ROOM
            EnemySoldier e7 = new EnemySoldier(new PointF(-750, 400));
            // SNIPER HALL
            EnemySoldier e8 = new EnemySoldier(new PointF(-770, -200));
            // LOWER MIDDLE
            EnemySoldier e9 = new EnemySoldier(new PointF(-85, 750));
            // UPPER MIDDLE
            EnemySoldier2 e10 = new EnemySoldier2(new PointF(-90, -600));
        }
        public static void Createweapons()
        {
            SuperBallLauncher sb1 = new SuperBallLauncher(new PointF(-700, -700));
            sb1.onground = true;
            mainform.weaponlist.Add(sb1);
            SniperGun sg1 = new SniperGun(new PointF(-775, 450));
            sg1.onground = true;
            mainform.weaponlist.Add(sg1);
            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(0, 0));
            health1.onground = true;
            mainform.healthlist.Add(health1);
            HealthPack health2 = new HealthPack("Images/HealthPack.png", new PointF(-780, 780));
            health2.onground = true;
            mainform.healthlist.Add(health2);
        }

        public static void Createweapons2()
        {
            SuperBallLauncher sb1 = new SuperBallLauncher(new PointF(0, 0));
            sb1.onground = true;
            mainform.weaponlist.Add(sb1);
            RapidGun rg1 = new RapidGun(new PointF(-700, -700));
            rg1.onground = true;
            mainform.weaponlist.Add(rg1);
            SniperGun sg1 = new SniperGun(new PointF(-775, 450));
            sg1.onground = true;
            mainform.weaponlist.Add(sg1);
            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(700, 750));
            health1.onground = true;
            mainform.healthlist.Add(health1);
            StunGun stg1 = new StunGun(new PointF(500, -650));
            mainform.weaponlist.Add(stg1);
            stg1.onground = true;
        }

        public static void Createenemies2()
        {
            // RAPID GUN HALL
            EnemySoldier3 e11 = new EnemySoldier3(new PointF(770, -200));
            //RAPID GUN ROOM
            EnemySoldier2 e12 = new EnemySoldier2(new PointF(750, 400));
            // SUPER BALL LAUNCHER
            EnemySoldier3 e13 = new EnemySoldier3(new PointF(-600, -520));
            // SUPER BALL LAUNCHER
            EnemySoldier2 e14 = new EnemySoldier2(new PointF(-650, -650));
            // PISTOL AREA
            EnemySoldier2 e15 = new EnemySoldier2(new PointF(100, 300));
            // PISTOL AREA
            EnemySoldier2 e16 = new EnemySoldier2(new PointF(200, 375));
            // PISTOL AREA
            Tank t2 = new Tank(new PointF(150, 275));
            // PISTOL AREA
            EnemySoldier2 e17 = new EnemySoldier2(new PointF(0, 0));
            // SNIPER ROOM
            EnemySoldier3 e18 = new EnemySoldier3(new PointF(-750, 400));
            // SNIPER HALL
            EnemySoldier e19 = new EnemySoldier(new PointF(-770, -200));
            // MIDDLE AREA
            Tank t3 = new Tank(new PointF(0, 10));
            // MIDDLE
            EnemySoldier3 e20 = new EnemySoldier3(new PointF(5, 5));
        }

        public static void Createweapons3()
        {
            SuperBallLauncher sb1 = new SuperBallLauncher(new PointF(-700, -700));
            sb1.onground = true;
            mainform.weaponlist.Add(sb1);
            RapidGun rg1 = new RapidGun(new PointF(775, 450));
            rg1.onground = true;
            mainform.weaponlist.Add(rg1);
            Pistol p1 = new Pistol(new PointF(800, 800));
            p1.onground = true;
            mainform.weaponlist.Add(p1);
            SniperGun sg1 = new SniperGun(new PointF(-775, 450));
            sg1.onground = true;
            mainform.weaponlist.Add(sg1);
            HealthPack health1 = new HealthPack("Images/HealthPack.png", new PointF(0, 0));
            health1.onground = true;
            mainform.healthlist.Add(health1);
            HealthPack health2 = new HealthPack("Images/HealthPack.png", new PointF(-780, 780));
            health2.onground = true;
            mainform.healthlist.Add(health2);
        }

        public static void Createenemies3()
        {
            // BOSS LEVEL
            Tank t4 = new Tank(new PointF(-0, -2100));
            EnemySoldier3 e21 = new EnemySoldier3(new PointF(300, -1700));
            EnemySoldier3 e22 = new EnemySoldier3(new PointF(-150, -1700));

        }

        public static void CreateBoss()
        {
            // BOSS
            BossTank b1 = new BossTank(new PointF(0, -2400));
        }


        public static void Createlevel()
        {
            initializelists();
            mainform.Player1 = new Player(new PointF(700, -700));
            createborders(-800, -800, 1600, 1600);
            createwalls();
            Createenemies();
            Createweapons();
        }

        public static void Createlevel2()
        {
            initializelists();
            mainform.Player1.location.X = 700;
            mainform.Player1.location.Y = -700;
            createborders(-800, -800, 1600, 1600);
            createwalls();
            Createenemies2();
            Createweapons2();
        }

        public static void Createlevel3()
        {
            initializelists();
            createborders(-800, -800, 1600, 1600);
            createwalls();
            Createenemies3();
            Createweapons3();
        }

    }
}
