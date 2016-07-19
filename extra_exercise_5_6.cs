using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise_5_6
{
    class Array
    {
        public void RandomValue(float[,] arr)
        {
            Random randomNumber = new Random(); // skapar ett objekt som finns i c# som kan generera ett slumpmässigt värde
            int Min = 0; // minsta värdet på slumpmässiga talet
            int Max = 20; // högsta värdet på slumpmässiga talet

            for (int i = 0; i < arr.GetLength(0); i++) // för varje index på rad1 i en 2D Array
            {
                for (int j = 0; j < arr.GetLength(1); j++) // för varje index på rad2 i en 2d Array
                {
                  arr[i, j] = randomNumber.Next(Min, Max); // för varje ny index i en Array, lägg ett nytt(.Next) slumpmässigt tal, håll talet inom 0-20
                }
            }
        }
        public void Print(float[,] arr)
        {
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Array();

            float[,] array1 = new float[100,100]; // tog 100 ggr 100, kan givetvis ta hur långt eller kort man vill. Testa kortare!

            array.RandomValue(array1);
            array.Print(array1);
            Console.ReadKey();
        }
    }
}