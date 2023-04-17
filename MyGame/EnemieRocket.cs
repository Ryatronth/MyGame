using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class EnemieRocket
    {
        public static void CreateSprite(PictureBox a)
        {
            var p = Form.ActiveForm;
            PictureBox enemieRocket = new PictureBox();
            enemieRocket.Location = new Point(a.Location.X + a.Width * 3 / 7, a.Location.Y + 80);
            enemieRocket.Size = new Size(9, 12);
            enemieRocket.BackgroundImage = Properties.Resources._1Rocket;
            enemieRocket.BackgroundImageLayout = ImageLayout.Stretch;
            enemieRocket.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            enemieRocket.Name = "EnemieRocket";
            p.Controls.Add(enemieRocket);
        }

        public static void GetEnemieRocket()
        {
            var p = Form.ActiveForm;
            var rand = new Random();
            foreach (Control enemie in p.Controls)
            {
                var value = rand.Next(0, 200);
                if (enemie.Name == "Alien")
                {
                    if (value == 1)
                        CreateSprite((PictureBox)enemie);
                }
            }

            foreach (Control elem in p.Controls)
            {
                if (elem.Name == "EnemieRocket")
                {
                    var enemieRocket = (PictureBox)elem;
                    enemieRocket.Top += 5;

                    if (enemieRocket.Location.Y >= 800)
                    {
                        p.Controls.Remove(enemieRocket);
                    }
                    foreach (Control obj in p.Controls)
                    {
                        if (obj.Name == "player")
                        {
                            if (enemieRocket.Bounds.IntersectsWith(obj.Bounds))
                            {
                                p.Controls.Remove(enemieRocket);
                                Player.LoseLife();

                                AlienShooter.points -= 30;
                            }
                        }
                    }
                }
            }
        }
    }
}
