using MyGame.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class Model
    {
        public static PictureBox player;

        public static void StartGame(Form p)
        {
            player = CreateControlPlayer(p);
            LifeCounter.CreateCounter(p);
            Score.counter = new Score().CreateSpritesLabel(p);
        }

        public static void GetPlayer()
        {
            Player.CrashPlayerAndAlien();
            Player.MovePlayer();
        }

        public static void GetRockets()
        {
            Rocket.InteractionWithRocket();
            EnemieRocket.GetEnemieRocket();
        }

        public static void GetBusters()
        {
            Busters.MoveBusters();
            Busters.ActivateBust();
        }

        public static void GetLevelsAndScore(Form p)
        {
            Score.GetScore();
            Levels.GetLevels(p);
        }    

        public static PictureBox CreateControlEnemieType1(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(Enemie.x, Enemie.y);
            pb.Size = new Size(Enemie.width, Enemie.height);
            pb.BackColor = Color.Black;
            pb.BackgroundImage = Properties.Resources.enemie1;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien1";
            pb.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            p.Controls.Add(pb);
            return pb;
        }

        public static PictureBox CreateControlEnemieType2(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(Enemie.x, Enemie.y);
            pb.Size = new Size(Enemie.width, Enemie.height);
            pb.BackgroundImage = Properties.Resources.enemie2;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien2";
            pb.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            p.Controls.Add(pb);
            return pb;
        }

        public static PictureBox CreateControlEnemieType3(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(Enemie.x, Enemie.y);
            pb.Size = new Size(Enemie.width, Enemie.height);
            pb.BackgroundImage = Properties.Resources.enemie3;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien3";
            pb.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            p.Controls.Add(pb);
            return pb;
        }

        public static PictureBox CreateSpriteRocketType1(PictureBox a)
        {
            var p = Form.ActiveForm;
            PictureBox enemieRocket = new PictureBox();
            enemieRocket.Location = new Point(a.Location.X + 25, a.Location.Y + 80);
            enemieRocket.BackColor = Color.Transparent;
            enemieRocket.Size = new Size(20, 20);
            enemieRocket.BackgroundImage = Properties.Resources._1Rocket;
            enemieRocket.BackgroundImageLayout = ImageLayout.Stretch;
            enemieRocket.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            enemieRocket.Name = "EnemieRocket";
            p.Controls.Add(enemieRocket);
            return enemieRocket;
        }

        public static PictureBox CreateSpriteRocketType2(PictureBox a)
        {
            var p = Form.ActiveForm;
            PictureBox enemieRocket = new PictureBox();
            enemieRocket.Location = new Point(a.Location.X, a.Location.Y + 80);
            enemieRocket.BackColor = Color.Transparent;
            enemieRocket.Size = new Size(15, 15);
            enemieRocket.BackgroundImage = Properties.Resources._2Rocket;
            enemieRocket.BackgroundImageLayout = ImageLayout.Stretch;
            enemieRocket.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            enemieRocket.Name = "EnemieRocket";
            p.Controls.Add(enemieRocket);
            return enemieRocket;
        }

        public static PictureBox CreateSpriteRocketType3(PictureBox a)
        {
            var p = Form.ActiveForm;
            PictureBox enemieRocket = new PictureBox();
            enemieRocket.Location = new Point(a.Location.X, a.Location.Y + 80);
            enemieRocket.BackColor = Color.Transparent;
            enemieRocket.Size = new Size(6, 30);
            enemieRocket.BackgroundImage = Properties.Resources._3Rocket;
            enemieRocket.BackgroundImageLayout = ImageLayout.Stretch;
            enemieRocket.Name = "EnemieRocket";
            p.Controls.Add(enemieRocket);
            return enemieRocket;
        }

        public static Control CreateControlSpeedBuster(PictureBox enemie)
        {
            var p = Form.ActiveForm;
            PictureBox speedBust = new PictureBox();
            speedBust.Location = new Point(enemie.Location.X, enemie.Location.Y);
            speedBust.Size = new Size(50, 50);
            speedBust.BackgroundImage = Properties.Resources.speed;
            speedBust.BackgroundImageLayout = ImageLayout.Stretch;
            speedBust.Name = "SpeedBuster";
            return speedBust;
        }

        public static Control CreateControlShieldBuster(PictureBox enemie)
        {
            var p = Form.ActiveForm;
            PictureBox shieldBust = new PictureBox();
            shieldBust.Location = new Point(enemie.Location.X, enemie.Location.Y);
            shieldBust.Size = new Size(50, 50);
            shieldBust.BackgroundImage = Properties.Resources.shield;
            shieldBust.BackgroundImageLayout = ImageLayout.Stretch;
            shieldBust.Name = "ShieldBuster";
            return shieldBust;
        }

        public static Control CreateControlAttackBuster(PictureBox enemie)
        {
            var p = Form.ActiveForm;
            PictureBox attackBust = new PictureBox();
            attackBust.Location = new Point(enemie.Location.X, enemie.Location.Y);
            attackBust.Size = new Size(50, 50);
            attackBust.BackgroundImage = Properties.Resources.attack;
            attackBust.BackgroundImageLayout = ImageLayout.Stretch;
            attackBust.Name = "AttackBuster";
            return attackBust;
        }

        public static PictureBox CreateControlRocket()
        {
            var p = Form.ActiveForm;
            var player = Model.player;
            PictureBox rocket = new PictureBox();
            rocket.Location = new Point(player.Location.X + player.Width * 2 / 5, player.Location.Y - 35);
            rocket.Size = new Size(16, 32);
            rocket.BackgroundImage = Properties.Resources.PRocket;
            rocket.BackgroundImageLayout = ImageLayout.Stretch;
            rocket.Name = "Rocket";
            p.Controls.Add(rocket);
            return rocket;
        }

        public static PictureBox CreateControlPlayer(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.BackColor = Color.Black;
            pb.Location = new Point(760, 720);
            pb.Size = new Size(70, 70);
            pb.BackgroundImage = Resources.player1;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "player";
            p.Controls.Add(pb);
            return pb;
        }
    }
}
