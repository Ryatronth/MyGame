using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class Score
    {
        public static Label counter;

        public static int points = 0;

        public Label CreateSpritesLabel(Form p)
        {
            return AlienShooter.CreateControlLabelCounter(p);
        }

        public static void GetScore()
        {
            counter.Text = "Счёт: " + points.ToString();
        }
    }
}
