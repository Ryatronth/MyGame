using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class EnemieRocket
    {
        public static void GetEnemieRocket()
        {
            var p = Form.ActiveForm;
            var rand = new Random();
            foreach (Control enemie in p.Controls)
            {
                var value = rand.Next(0, 300);
                if (enemie.Name == "Alien1")
                {
                    if (value == 1)
                        Model.CreateSpriteRocketType1((PictureBox)enemie);
                }
                if (enemie.Name == "Alien2")
                {
                    if (value == 1)
                    {
                        var rocket1 = Model.CreateSpriteRocketType2((PictureBox)enemie);
                        var rocket2 = Model.CreateSpriteRocketType2((PictureBox)enemie);
                        rocket1.Location = new Point(enemie.Location.X + 5, enemie.Location.Y + 80);
                        rocket2.Location = new Point(enemie.Location.X + 50, enemie.Location.Y + 80);
                    }                      
                }
                if (enemie.Name == "Alien3")
                {
                    if (value == 1)
                    {
                        var rocket1 = Model.CreateSpriteRocketType3((PictureBox)enemie);
                        var rocket2 = Model.CreateSpriteRocketType3((PictureBox)enemie);
                        var rocket3 = Model.CreateSpriteRocketType3((PictureBox)enemie);
                        rocket1.Location = new Point(enemie.Location.X + 28, enemie.Location.Y + 80);
                        rocket2.Location = new Point(enemie.Location.X + 33, enemie.Location.Y + 80);
                        rocket3.Location = new Point(enemie.Location.X + 38, enemie.Location.Y + 80);
                    }
                }
            }

            foreach (Control elem in p.Controls)
            {
                if (elem.Name == "EnemieRocket")
                {
                    var enemieRocket = (PictureBox)elem;
                    enemieRocket.Top += 3;

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
                                Busters.GetShieldBust();
                                p.Controls.Remove(enemieRocket);
                            }
                        }
                    }
                }
            }
        }
    }
}
