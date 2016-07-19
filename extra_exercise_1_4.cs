using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise_1_4
{
    class Array
    {
        public float GetMaxValue(float[] arr)
        {
            return arr.Max();
        }
        public float GetMinValue(float[] arr)
        {
            return arr.Min();
        }
        public float ReturnAverage(float[] arr)
        {
            return arr.Average();
        }
        public bool CheckCondition(int x, int y, int z, bool flag)
        {
            if (y > 10 || y < 20 || x <= 0 || z > 10 || z < 20)
            {
                flag = true;
            }
            return flag;
        }
        public void Print(float[,] arr)
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

    class ASCII
    {
        public void PrintAscii()
        {
            Console.OutputEncoding = Encoding.ASCII;

            int column = 0;
            for (byte counter = 32; counter < 128; counter++)
            {
                if (column == 0)
                {
                    Console.Write("0x{0:X}  ", counter);
                }
                Console.Write(" {0}  ", (char)counter);
                if (++column > 7)
                {
                    column = 0;
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera objekt
            var array = new Array();
            var ascii = new ASCII();

            // Deklarera arrays
            float[] array1 = { 10, 20, 30 };
            float[,] array2 = { { 0, 0, 15, 0, 10 }, { 20, 34, 36, 38, 0 } };


            // Print för alla uppgifter och metoder förutom check condition
            Console.WriteLine("max: " + array.GetMaxValue(array1) + ". min: " + array.GetMinValue(array1) + ". Averge: " + array.ReturnAverage(array1));
            array.Print(array2);
            ascii.PrintAscii();

            Console.ReadKey();
        }
    }
}