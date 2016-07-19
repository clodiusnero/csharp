using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_excercises_4_6
{
    class Array
    {
        public void RandomValueForArray(float[,] arr)
        {
            Random randomNumber = new Random(); 
            int Min = 0; 
            int Max = 20; 

            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    arr[i, j] = randomNumber.Next(Min, Max); 
                }
            }
        }
        public void CountNeighbors(float[,] arr, int x, int y)
        {
            int count = 0;

            // Check for x - 1, y - 1
            if (x > 0 && y > 0)
            {
                if (arr[y - 1, x - 1] == 1)
                    count++;
            }

            // Check for x, y - 1
            if (y > 0)
            {
                if (arr[y - 1, x] == 1)
                    count++;
            }

            // Check for x + 1, y - 1
            if (x < arr.GetLength(1) - 1 && y > 0)
            {
                if (arr[y - 1, x + 1] == 1)
                    count++;
            }

            // Check for x - 1, y
            if (x > 0)
            {
                if (arr[y, x - 1] == 1)
                    count++;
            }

            // Check for x + 1, y
            if (x < arr.GetLength(0) - 1)
            {
                if (arr[y, x + 1] == 1)
                    count++;
            }

            // Check for x - 1, y + 1
            if (x > 0 && y < arr.GetLength(0) - 1)
            {
                if (arr[y + 1, x - 1] == 1)
                    count++;
            }

            // Check for x, y + 1
            if (y < arr.GetLength(0) - 1)
            {
                if (arr[y + 1, x] == 1)
                    count++;
            }

            // Check for x + 1, y + 1
            if (x < arr.GetLength(0) - 1 && y < arr.GetLength(1) - 1)
            {
                if (arr[y + 1, x + 1] == 1)
                    count++;
            }
            Console.WriteLine(count);
        }

        public void Print(float[,] arr)
        {

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
            }
        }
        public void Print2(float[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0}\t", arr[i, j]));
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Array();

            float[,] array1 = new float[10, 10]; // tog 100 ggr 100, kan givetvis ta hur långt eller kort man vill. Testa kortare!

            array.RandomValueForArray(array);

            array.Print2(array1);

            Console.ReadKey();
        }
    }
}
