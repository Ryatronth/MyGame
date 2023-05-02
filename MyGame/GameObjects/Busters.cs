using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class Busters
    {
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

        public static void ActivateBust()
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
                                if (buster.Name.Contains("Speed") && !Player.speedBust)
                                {
                                    speedBusterFlag();
                                }
                                if (buster.Name.Contains("Shield"))
                                {
                                    shieldBusterFlag();
                                }
                                if (buster.Name.Contains("Attack"))
                                {
                                    attackBusterFlag();
                                }
                                p.Controls.Remove(buster);

                                Score.points += 5;
                            }
                        }
                    }
                }
            }
        }

        public static async void speedBusterFlag()
        {
            Player.speedBust = true;
            await Task.Delay(5000);
            Player.speedBust = false;
        }

        public static async void shieldBusterFlag()
        {
            Player.shieldBust = true;
            await Task.Delay(5000);
            Player.shieldBust = false;
        }

        public static async void attackBusterFlag()
        {
            Player.attackBust = true;
            await Task.Delay(5000);
            Player.attackBust = false;
        }

        public static void GetRocketWithBust()
        {
            var player = Model.player;
            var rocket1 = Model.CreateControlRocket();
            var rocket2 = Model.CreateControlRocket();
            var rocket3 = Model.CreateControlRocket();
            rocket1.Location = new Point(player.Location.X, player.Location.Y - 35);
            rocket3.Location = new Point(player.Location.X + player.Width - 15, player.Location.Y - 35);
        }

        public static void GetSpeedBust()
        {
            if (Player.speedBust) Player.jump = 6;
            else Player.jump = 3;
        }

        public static void GetShieldBust()
        {
            if (!Player.shieldBust)
            {
                LifeCounter.LoseLife();
                Score.points -= 30;
            }
        }
    }
}
