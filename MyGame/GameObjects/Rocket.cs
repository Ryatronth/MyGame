using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class Rocket
    {
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
                        if (alien.Name.Contains("Alien"))
                        {
                            if (rocket.Bounds.IntersectsWith(alien.Bounds))
                            {
                                var value = rand.Next(0, 15);
                                p.Controls.Remove(rocket);
                                p.Controls.Remove(alien);
                                if (value == 1)
                                    p.Controls.Add(Model.CreateControlSpeedBuster((PictureBox)alien));
                                if (value == 2)
                                    p.Controls.Add(Model.CreateControlShieldBuster((PictureBox)alien));
                                if (value == 3)
                                    p.Controls.Add(Model.CreateControlAttackBuster((PictureBox)alien));

                                Score.points += 5;
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
                                
                                Score.points += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
