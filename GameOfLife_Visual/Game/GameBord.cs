using System;

namespace GameOfLife_Visual.Clases
{
    class GameBord
    {
        int Lines, Rows;
        public bool[,] Bord;
        public bool[,] PrevBord;
        public GameBord(int lines, int rows)
        {
            Lines = lines;
            Rows = rows;

            Bord = new bool[Lines, Rows];

            for (int i = 0; i < Lines; i++)
                for (int j = 0; j < Rows; j++)
                    Bord[i, j] = false;
            Generate();
        }

        public void Simulate()
        {
            //bool[,] bord = new bool[Rows,Lines];
            bool[,] bord = (bool[,])Bord.Clone();
            PrevBord = (bool[,])Bord.Clone();

            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    int nr = numberOfNg(i, j);
                    if (nr > 3)
                        bord[i, j] = false;
                    else if (nr == 3)
                        bord[i, j] = true;
                    else if (nr < 2)
                        bord[i, j] = false;
                }
            }

            Bord = (bool[,])bord.Clone();

            //Console.Write("\n----------\n");
            //PrintPixels();
            //Console.ReadKey();
            //Thread.Sleep(40);
            //Console.Clear();
        }

        private int numberOfNg(int I, int J)
        {
            int ct = 0;
            for (int i = lowLimit(I); i <= highLimit(I, Lines); i++)
                for (int j = lowLimit(J); j <= highLimit(J, Rows); j++)
                    if (Bord[i, j] && !(i == I && j == J)) ct++;

            return ct;

        }

        private int lowLimit(int coord)
        {
            if (coord - 1 < 0)
                return 0;
            return coord - 1;
        }
        private int highLimit(int coord, int limit)
        {
            if (coord + 1 >= limit) return limit - 1;
            return coord + 1;
        }

        private void Generate(int procentage = 50)
        {
            Random random = new Random();
            for (int i = 0; i < Lines; i++)
                for (int j = 0; j < Rows; j++)
                    if (random.Next(1, 101) < procentage)
                        Bord[i, j] = true;
        }

        public void PrintPixels()
        {
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (Bord[i, j] == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
/* public void Test()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Lines; j++)
                    Console.WriteLine("The element " + i + ' ' + j + " has " + numberOfNg(i, j) + " Neibors");
        } */