using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class Levels : Enemie
    {
        private static bool level1, level2, level3, level4 = false;

        public static bool wonGame = false;

        public static void GetLevels(Form p)
        {
            GetLevelMoves(p);
            if (!level1)
            {
                new Levels().getLevel1(p);
                level1 = true;
            }
            if (!level2 && ChekWinInLvl(p))
            {
                new Levels().getLevel2(p);
                level2 = true;
            }
            if (!level3 && ChekWinInLvl(p))
            {
                new Levels().getLevel3(p);
                level3 = true;
            }
            if (!level4 && ChekWinInLvl(p))
            {
                new Levels().getLevel4(p);
                level4 = true;
            }
            if (level4 && ChekWinInLvl(p))
                wonGame = true;
        }

        private static void GetLevelMoves(Form p)
        {
            if (level1 && !level2)
                AlienMoveLvl1(p);
            if (level2 && !level3)
                AlienMoveLvl2(p);
            if (level3 && !level4)
                AlienMoveLvl3(p);
            if (level4 && !wonGame)
                AlienMoveLvl4(p);
        }

        private void getLevel1(Form p)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var value = rand.Next(0, 2);
                    if (value == 1)
                    {
                        Model.CreateControlEnemieType1(p);
                    }
                    x += width;
                }
                y += height;
                x = 360;
            }
        }

        private void getLevel2(Form p)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var value = rand.Next(0, 3);
                    if (value == 1)
                    {
                        Model.CreateControlEnemieType1(p);
                    }
                    if (value == 2)
                    {
                        Model.CreateControlEnemieType2(p);
                    }
                    x += width;
                }
                y += height;
                x = 360;
            }
        }

        private void getLevel3(Form p)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var value = rand.Next(0, 5);
                    if (value == 1)
                    {
                        Model.CreateControlEnemieType1(p);
                    }
                    if (value == 2)
                    {
                        Model.CreateControlEnemieType2(p);
                    }
                    if (value == 3)
                    {
                        Model.CreateControlEnemieType3(p);
                    }
                    x += width;
                }
                y += height;
                x = 360;
            }
        }

        private void getLevel4(Form p)
        {
            var rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var value = rand.Next(0, 2);
                    if (value == 1)
                    {
                        Model.CreateControlEnemieType1(p);
                    }
                    x += width;
                }
                y += height;
                x = 360;
            }
        }

        private static bool moveLeft, moveRight, moveBot, moveTop, checkMove = false;

        private static void movesLeft(Control enemie, Form p)
        {
            if (p.GetChildAtPoint(new Point(enemie.Location.X - 1, enemie.Location.Y), GetChildAtPointSkip.Transparent) == null)
            {
                enemie.Location = new Point(enemie.Location.X - 2, enemie.Location.Y);
            }
        }

        private static void movesRight(Control enemie, Form p)
        {
            if (p.GetChildAtPoint(new Point(enemie.Location.X + 70, enemie.Location.Y), GetChildAtPointSkip.Transparent) == null)
            {
                enemie.Location = new Point(enemie.Location.X + 2, enemie.Location.Y);
            }
        }

        private static void movesTop(Control enemie, Form p)
        {
            if (p.GetChildAtPoint(new Point(enemie.Location.X, enemie.Location.Y - 10), GetChildAtPointSkip.Transparent) == null)
            {
                enemie.Location = new Point(enemie.Location.X, enemie.Location.Y - 2);
            }
        }

        private static void movesBot(Control enemie, Form p)
        {
            if (p.GetChildAtPoint(new Point(enemie.Location.X, enemie.Location.Y + 70), GetChildAtPointSkip.Transparent) == null)
            {
                enemie.Location = new Point(enemie.Location.X, enemie.Location.Y + 2);
            }
        }

        private static async void AlienMoveLvl1(Form p)
        {
            await Task.Run(() =>
            {
                foreach (Control enemie in p.Controls)
                {
                    if (enemie.Name.Contains("Alien"))
                    {
                        if (!checkMove)
                        {
                            moveLeft = true;
                            moveBot = false;
                            moveRight = false;
                            moveTop = false;
                            checkMove = true;
                        }
                        if (moveLeft && enemie.Location.X > 100)
                        {
                            movesLeft(enemie, p);
                        }
                        else if (enemie.Location.X < 110)
                        {
                            moveLeft = false;
                            moveRight = true;
                        }
                        if (moveRight && enemie.Location.X < 1400)
                        {
                            movesRight(enemie, p);
                        }
                        else if (enemie.Location.X > 1390)
                        {
                            moveRight = false;
                            moveLeft = true;
                        }
                    }
                }
            });
        }

        private static async void AlienMoveLvl2(Form p)
        {
            await Task.Run(() =>
            {
                foreach (Control enemie in p.Controls)
                {
                    if (enemie.Name.Contains("Alien"))
                    {
                        if (!checkMove)
                        {
                            moveLeft = true;
                            moveBot = false;
                            moveRight = false;
                            moveTop = false;
                            checkMove = true;
                        }
                        if (moveLeft && enemie.Location.X > 100)
                        {
                            movesLeft(enemie, p);
                        }
                        else if (enemie.Location.X < 110)
                        {
                            moveLeft = false;
                            moveBot = true;
                        }
                        if (moveBot && enemie.Location.Y < 500)
                        {
                            movesBot(enemie, p);
                        }
                        else if (enemie.Location.Y > 490)
                        {
                            moveBot = false;
                            moveRight = true;
                        }
                        if (moveRight && enemie.Location.X < 1400)
                        {
                            movesRight(enemie, p);
                        }
                        else if (enemie.Location.X > 1390)
                        {
                            moveRight = false;
                            moveTop = true;
                        }
                        if (moveTop && enemie.Location.Y > 30)
                        {
                            movesTop(enemie, p);
                        }
                        else if (enemie.Location.Y < 40)
                        {
                            moveTop = false;
                            moveLeft = true;
                        }
                    }
                }
            });
        }

        private static async void AlienMoveLvl3(Form p)
        {
            await Task.Run(() =>
            {
                foreach (Control enemie in p.Controls)
                {
                    if (enemie.Name.Contains("Alien"))
                    {
                        if (!checkMove)
                        {
                            moveLeft = true;
                            moveBot = false;
                            moveRight = false;
                            moveTop = false;
                            checkMove = true;
                        }
                        if (moveLeft && enemie.Location.X > 770 && enemie.Location.X < 1520)
                        {
                            movesRight(enemie, p);
                        }
                        if (moveLeft && enemie.Location.X < 770 && enemie.Location.X > 10)
                        {
                            movesLeft(enemie, p);
                        }
                        else if (moveLeft && enemie.Location.X < 20 || moveLeft && enemie.Location.X > 1450)
                        {
                            moveLeft = false;
                            moveRight = true;
                        }
                        if (moveRight && enemie.Location.X > 770)
                        {
                            movesLeft(enemie, p);
                        }
                        if (moveRight && enemie.Location.X < 700)
                        {
                            movesRight(enemie, p);
                        }
                        else if (moveRight && enemie.Location.X > 690 && enemie.Location.X < 700 || moveRight && enemie.Location.X > 770 && enemie.Location.X <780)
                        {
                            moveRight = false;
                            moveBot = true;
                        }
                        if (moveBot && enemie.Location.Y < 600)
                        {
                            movesBot(enemie, p);
                        }
                        else if (enemie.Location.Y > 590)
                        {
                            moveBot = false;
                            moveTop = true;
                        }
                        if (moveTop && enemie.Location.Y > 30)
                        {
                            movesTop(enemie, p);
                        }
                        else if (enemie.Location.Y < 40 && moveTop)
                        {
                            moveTop = false;
                            moveLeft = true;
                        }
                    }
                }
            });
        }

        private static async void AlienMoveLvl4(Form p)
        {
            await Task.Run(() =>
            {
                foreach (Control enemie in p.Controls)
                {
                    if (enemie.Name.Contains("Alien"))
                    {
                        if (!checkMove)
                        {
                            moveLeft = false;
                            moveBot = true;
                            moveRight = false;
                            moveTop = false;
                            checkMove = true;
                        }
                        if (moveBot && enemie.Location.X > 770 && enemie.Location.Y > 30)
                        {
                            movesTop(enemie, p);
                        }
                        if (moveBot && enemie.Location.X < 770 && enemie.Location.Y < 500)
                        {
                            movesBot(enemie, p);
                        }
                        else if (enemie.Location.Y > 490 && enemie.Location.X < 770)
                        {
                            moveBot = false;
                            moveTop = true;
                        }
                        if (moveTop && enemie.Location.Y > 30 && enemie.Location.X < 770)
                        {
                            movesTop(enemie, p);
                        }
                        if (enemie.Location.X > 770 && !moveBot && enemie.Location.Y < 500)
                        {
                            movesBot(enemie, p);
                        }
                        else if (enemie.Location.X > 770 && enemie.Location.Y > 490)
                        {
                            moveTop = false;
                            moveBot = true;
                        }
                    }
                }
            });
        }

        private static bool ChekWinInLvl(Form p)
        {
            var counter = 0;
            foreach(Control enemie in p.Controls)
            {
                if (enemie.Name.Contains("Alien"))
                    counter++;
            }
            if (counter == 0)
            {
                checkMove = false;
                return true;
            }
            return false;
        }       
    }
}
