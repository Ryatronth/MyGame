using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MyGame
{
    class Rocket
    {
        Image pRocket = Properties.Resources.playerRocket;
        public static void GetRocket()
        {
            var p = Form.ActiveForm;
            var player = AlienShooter.player;
            PictureBox rocket = new PictureBox();
            rocket.Location = new Point(player.Location.X + player.Width * 2 / 5, player.Location.Y - 35);
            rocket.Size = new Size(16, 32);
            rocket.BackgroundImage = Properties.Resources.playerRocket;
            rocket.BackgroundImageLayout = ImageLayout.Stretch;
            rocket.Name = "Rocket";
            p.Controls.Add(rocket);
        }

        public static void InteractionWithRocket()
        {
            var p = Form.ActiveForm;
            var rand = new Random();
            foreach (Control rock in p.Controls)
            {
                if (rock.Name == "Rocket")
                {
                    var rocket = (PictureBox)rock;
                    rocket.Top -= 5;

                    if (rocket.Location.Y <= 0)
                    {
                        p.Controls.Remove(rocket);
                    }
                    foreach (Control alien in p.Controls)
                    {
                        if (alien.Name == "Alien")
                        {
                            if (rocket.Bounds.IntersectsWith(alien.Bounds))
                            {
                                var value = rand.Next(0, 10);
                                p.Controls.Remove(rocket);
                                p.Controls.Remove(alien);
                                if (value == 1)
                                    p.Controls.Add(Busters.GetSpeedBuster((PictureBox)alien));
                                
                                AlienShooter.points += 5;
                            }
                        }
                    }
                    foreach (Control enemieRocket in p.Controls)
                    {
                        if (enemieRocket.Name == "EnemieRocket")
                        {
                            if (rocket.Bounds.IntersectsWith(enemieRocket.Bounds))
                            {
                                p.Controls.Remove(rocket);
                                p.Controls.Remove(enemieRocket);
                                
                                AlienShooter.points += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
