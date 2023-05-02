using MyGame.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{   
    class Player
    {
        public static void CrashPlayerAndAlien()
        {
            var p = Form.ActiveForm;
            foreach (Control alien in p.Controls)
            {
                if (alien.Name == "Alien")
                {
                    if (Model.player.Bounds.IntersectsWith(alien.Bounds))
                    {
                        LifeCounter.LoseLife();
                        p.Controls.Remove(alien);
                    }
                }
            }
        }

        public static bool speedBust, shieldBust, attackBust;     

        public static bool moveLeft, moveRight, moveTop, moveBottom, rocket;

        public static int jump = 3;

        public static int x;
        public static int y;

        public static void MovePlayer()
        {
            x = Model.player.Location.X;
            y = Model.player.Location.Y;
            Busters.GetSpeedBust();
            if (moveLeft == true && x > 0)
                x -= jump;
            if (moveRight == true && x < 1530)
                x += jump;
            if (moveTop == true && y > 0)
                y -= jump;
            if (moveBottom == true && y < 720)
                y += jump;
            Model.player.Location = new Point(x, y);
        }
    }
}
