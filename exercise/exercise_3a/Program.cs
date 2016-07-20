using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome!\n\nThis program takes any number you enter,\nbreaks it down to all it's containing integers,\nthen adds them all up.\n\n*Only use numbers, no letters.\n*No negative numbers.\n*Press Enter after the number.\n-----------------------------------------------------------\nYour integer: ");
            var input = int.Parse(Console.ReadLine());
            var sum = 0;
            while (input <= 0)
            {
                Console.Write("\nSorry you cannot enter a negative number. Only use positive ones.\n\nYour integer: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.Write("0");
            for (var i = 1; i <= input; Console.Write(" + " + i++))
            {
                sum + -i;
            }
            Console.Write(" = " + sum + ".\n\nThank you!\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
