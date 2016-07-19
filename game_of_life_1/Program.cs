using System;
using System.Threading;


namespace game_of_life_1
{
    class Grid
    {
        int[,] arr;
        int[,] previousArr;

        int col;
        int row;

        int arrCount;

        private int CountNeighbours(int x, int y)
        {
            int count = 0;

            if (x > 0 && y > 0)
            {
                if (arr[y - 1, x - 1] == 1)
                    count++;
            }

            if (y > 0)
            {
                if (arr[y - 1, x] == 1)
                    count++;
            }

            if (x < col - 1 && y > 0)
            {
                if (arr[y - 1, x + 1] == 1)
                    count++;
            }

            if (x > 0)
            {
                if (arr[y, x - 1] == 1)
                    count++;
            }

            if (x < col - 1)
            {
                if (arr[y, x + 1] == 1)
                    count++;
            }

            if (x > 0 && y < row - 1)
            {
                if (arr[y + 1, x - 1] == 1)
                    count++;
            }

            if (y < row - 1)
            {
                if (arr[y + 1, x] == 1)
                    count++;
            }

            if (x < col - 1 && y < row - 1)
            {
                if (arr[y + 1, x + 1] == 1)
                    count++;
            }

            return count;
        }

        public void Print()
        {

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < col; x++)
                    if (arr[y, x] > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                    }
                Console.WriteLine(" ");
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
        public int ArrCount
        {
            get { return arrCount; }
        }

        public Grid(int[,] newGrid)
        {
            var max = 2;
            var min = 0;

            arr = (int[,])newGrid.Clone();

            Random randomNumber = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = randomNumber.Next(min, max);
                }
            }

            arrCount = 1;

            col = arr.GetLength(1);
            row = arr.GetLength(0);

            previousArr = new int[row, col];
        }

        public void ProcessGame()
        {
            int[,] nextArr = new int[row, col];

            previousArr = (int[,])arr.Clone();

            arrCount++;

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    if (arr[y, x] == 0 && CountNeighbours(x, y) == 3)
                        nextArr[y, x] = 1;
                    if (arr[y, x] == 1 &&
                           (CountNeighbours(x, y) == 2 || CountNeighbours(x, y) == 3))
                        nextArr[y, x] = 1;
                }
            }
            arr = (int[,])nextArr.Clone();
        }

        public int AliveCells()
        {
            int count = 0;

            for (int y = 0; y < row; y++)
                for (int x = 0; x < col; x++)
                    if (arr[y, x] == 1)
                        count++;

            return count;
        }

        static void Main(string[] args)
        {
            Console.Title = "Anton & Kristofers, GAME OF LIFE";

            int[,] grid = new int[25, 25];

            Grid gameGrid = new Grid(grid);

            Console.WriteLine("MOVE 0");
            gameGrid.Print();

            while (gameGrid.AliveCells() > 0)
            {
                Console.WriteLine("MOVE {0}", gameGrid.ArrCount);

                gameGrid.ProcessGame();
                gameGrid.Print();

                if (gameGrid.AliveCells() == 0)
                {
                    Console.WriteLine("You have reached the fate of mankind.");
                    Console.ReadLine();
                }
            }

        }
    }
}