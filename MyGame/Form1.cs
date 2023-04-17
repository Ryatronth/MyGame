using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyGame
{
    public partial class AlienShooter : Form
    {
        public AlienShooter()
        {                    
            InitializeComponent();

            new Enemie().CreateSprites(this);
            player = new Player().CreateSprites(this);
        }

        public static PictureBox player;

        bool moveLeft, moveRight, moveTop, moveBottom, rocket;      

        public static int jump = 3;

        public static int points = 0;      

        public void Score(int points)
        {
            Counter.Text = "Очки: " + points.ToString();
        }

        private void GetScore(object sender, EventArgs e)
        {
            Score(points);
        }      

        private void MovePlayer(object sender, EventArgs e)
        {
            if (moveLeft == true && player.Left > 0)
                player.Left -= jump;
            if (moveRight == true && player.Right < 1600)
                player.Left += jump;
            if (moveTop == true && player.Top > 0)
                player.Top -= jump;
            if (moveBottom == true && player.Bottom < 815)
                player.Top += jump;
            Player.CrashPlayer();
        }

        private void TimeOfBusts(object sender, EventArgs e)
        {
            Busters.GetTimeBust();
        }

        private void RocketsBustersMove(object sender, EventArgs e)
        {
            Rocket.InteractionWithRocket();
            Busters.MoveBusters();
        }

        private void KeysDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                moveLeft = true;
            else if (e.KeyCode == Keys.D)
                moveRight = true;
            else if (e.KeyCode == Keys.W)
                moveTop = true;

            else if (e.KeyCode == Keys.S)
                moveBottom = true;
            else if (e.KeyCode == Keys.Space)
            {
                rocket = true;
                Rocket.GetRocket();
            }           
        }

        private void KeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                moveLeft = false;
            else if (e.KeyCode == Keys.D)
                moveRight = false;
            else if (e.KeyCode == Keys.W)
                moveTop = false;
            else if (e.KeyCode == Keys.S)
                moveBottom = false;
            else if (e.KeyCode == Keys.Space)
                rocket = false;
        }

        private void GetEnemieRocket(object sender, EventArgs e)
        {
            EnemieRocket.GetEnemieRocket();
        }
    }
}
