using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class Enemie
    {
        private int width, height;
        private int columns, rows;
        private int x, y;

        public Enemie()
        {
            width = 70;
            height = 70;
            columns = 12;
            rows = 4;
            x = 360;
            y = 0;
        }


        private PictureBox CreateControl(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x, y);
            pb.Size = new Size(width, height);
            pb.BackgroundImage = Properties.Resources.enemie1;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien";
            pb.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            p.Controls.Add(pb);
            return pb;
        }

        public void CreateSprites(Form p)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var value = rand.Next(0, 2);
                    if (value == 1)
                    {
                        CreateControl(p);
                    }
                    x += width;
                }
                y += height;
                x = 360;
            }
        }        
    }
}
