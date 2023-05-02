using MyGame.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class LifeCounter
    {
        public static void CreateCounter(Form p)
        {
            AlienShooter.CreateControlHeart(p, 250, 800);
            AlienShooter.CreateControlHeart(p, 190, 800);
            AlienShooter.CreateControlHeart(p, 130, 800);
            AlienShooter.CreateControlLabelLife(p);
        }

        public static int lifeCounter = 3;

        public static void LoseLife()
        {
            var p = Form.ActiveForm;

            lifeCounter--;

            Model.player.Location = new Point(760, 720);
            Busters.shieldBusterFlag();


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
