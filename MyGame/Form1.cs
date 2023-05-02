using MyGame.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MyGame
{
    public partial class AlienShooter : Form
    {
        public AlienShooter()
        {
            InitializeComponent();

            Model.StartGame(this);
        }

        public static PictureBox CreateControlHeart(Form p, int x, int y)
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(50, 50);
            pb.BackColor = Color.Transparent;
            pb.BackgroundImage = Resources.life;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Location = new Point(x, y);
            pb.Name = "Life";
            p.Controls.Add(pb);
            return pb;
        }

        public static Label CreateControlLabelLife(Form p)
        {
            Label pb = new Label();
            pb.BackColor = Color.Transparent;
            pb.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pb.ForeColor = Color.White;
            pb.Location = new Point(12, 810);
            pb.Name = "LCounter";
            pb.Size = new Size(99, 31);
            pb.Text = "Жизни:";
            p.Controls.Add(pb);
            return pb;
        }

        public static Label CreateControlLabelCounter(Form p)
        {
            Label pb = new Label();
            pb.BackColor = Color.Black;
            pb.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            pb.ForeColor = Color.White;
            pb.Location = new Point(1430, 810);
            pb.Name = "Counter";
            pb.Size = new Size(150, 31);
            pb.Text = "Счёт: ";
            p.Controls.Add(pb);
            return pb;
        }

        private void WonGame()
        {
            if(Levels.wonGame == true)
            {
                Timer.Enabled = false;
                var m = MessageBox.Show("Вы победили!");
                this.Close();
            }
        }

        private void LoseGame()
        {
            if(LifeCounter.lifeCounter == 0)
            {
                Timer.Enabled = false;
                var m = MessageBox.Show("Вы проиграли.");
                this.Close();
            }
        }

        private bool stopGame = false;

        private void KeysDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                Player.moveLeft = true;
            else if (e.KeyCode == Keys.D)
                Player.moveRight = true;
            else if (e.KeyCode == Keys.W)
                Player.moveTop = true;

            else if (e.KeyCode == Keys.S)
                Player.moveBottom = true;
            else if (e.KeyCode == Keys.Space)
            {
                Player.rocket = true;
                if (Player.attackBust)
                    Busters.GetRocketWithBust();
                Model.CreateControlRocket();
            }
            else if (e.KeyCode == Keys.Escape && !stopGame)
            {
                Timer.Stop();
                stopGame = true;
            }
            else if (e.KeyCode == Keys.Escape && stopGame)
            {
                Timer.Start();
                stopGame = false;
            }
        }

        private void KeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                Player.moveLeft = false;
            else if (e.KeyCode == Keys.D)
                Player.moveRight = false;
            else if (e.KeyCode == Keys.W)
                Player.moveTop = false;
            else if (e.KeyCode == Keys.S)
                Player.moveBottom = false;
            else if (e.KeyCode == Keys.Space)
                Player.rocket = false;
        }

        private void GameTimer(object sender, EventArgs e)
        {
            Model.GetLevelsAndScore(this);
            Model.GetPlayer();
            Model.GetBusters();
            Model.GetRockets();
            LoseGame();
            WonGame();
        }
    }
}
