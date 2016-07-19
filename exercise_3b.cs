using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercise_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A Calculator\n\nCalculate two numbers.\n\n*You may only use numbers, no space or letters.\n");
            ConsoleKeyInfo cki;
            do
            {
                Console.Write("\nEnter the first number: ");
                var x = float.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                var y = float.Parse(Console.ReadLine());
                Console.Write("\nSelect a operation\n<1> Addition\n<2> Subtration\n<3> Multification\n<4> Division\nOperation: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nResult: " + (x + y));
                        break;
                    case 2:
                        Console.Write("\nResult: " + (x - y));
                        break;
                    case 3:
                        Console.Write("\nResult: " + (x * y));
                        break;
                    case 4:
                        Console.Write("\nResult: " + (x / y));
                        break;
                }
                Console.Write("\n\n ...Press <Esc> to exit, press any other key to make another calculation. ");
                cki = Console.ReadKey();
                Console.WriteLine();
            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}