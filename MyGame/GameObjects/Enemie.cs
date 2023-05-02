using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class Enemie
    {
        public static int width, height;
        public static int columns, rows;
        public static int x, y;

        public static List<Control> enemies = new List<Control>();

        public Enemie()
        {
            width = 70;
            height = 70;
            columns = 12;
            rows = 4;
            x = 360;
            y = 30;
        }

        public static void CreateListEnemies(Form p)
        {
            foreach (Control enemie in p.Controls)
            {
                if (enemie.Name.Contains("Alien"))
                    enemies.Add(enemie);
            }
        }
    }
}
