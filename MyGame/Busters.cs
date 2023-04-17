using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyGame
{
    class Busters
    {
        public static Control GetSpeedBuster(PictureBox enemie)
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

        public static void MoveBusters()
        {
            var p = Form.ActiveForm;
            foreach (Control buster in p.Controls)
            {
                if (buster.Name.Contains("Buster"))
                {
                    buster.Top += 3;
                }
            }
        }

        public static void GetTimeBust()
        {
            var p = Form.ActiveForm;
            foreach (Control buster in p.Controls)
            {
                if (buster.Name.Contains("Buster"))
                {
                    foreach (Control player in p.Controls)
                    {
                        if (player.Name == "player")
                        {
                            if (buster.Bounds.IntersectsWith(player.Bounds))
                            {
                                if (buster.Name.Contains("Speed"))
                                {
                                    AlienShooter.jump += 3;
                                }                                   
                                p.Controls.Remove(buster);

                                AlienShooter.points += 5;
                            }
                        }
                    }
                }
            }
        }
    }
}
