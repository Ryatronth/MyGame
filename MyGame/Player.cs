using MyGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MyGame
{
    class Player
    {
        static int lifeCounter = 3;
        private PictureBox CreateControl(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(760, 720);
            pb.Size = new Size(70, 70);
            pb.BackgroundImage = Properties.Resources.player1;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "player";
            p.Controls.Add(pb);
            return pb;
        }

        public PictureBox CreateSprites(Form p)
        {
            return CreateControl(p);
        }

        public static void CrashPlayer()
        {
            var p = Form.ActiveForm;
            foreach (Control alien in p.Controls)
            {
                if (alien.Name == "Alien")
                {
                    if (AlienShooter.player.Bounds.IntersectsWith(alien.Bounds))
                    {
                        Player.LoseLife();
                        p.Controls.Remove(alien);
                    }
                }
            }
        }

        public static void LoseLife()
        {
            var p = Form.ActiveForm;

            lifeCounter--;

            if (lifeCounter == 0)
            {
                p.Close();
            }
            AlienShooter.player.Location = new Point(760, 720);           

            foreach (Control c in p.Controls)
            {
                if (c.Name.Contains("Life") && c.Visible == true)
                {
                    PictureBox player = (PictureBox)c;
                    player.Visible = false;
                    return;
                }
            }
        }
    }
}
