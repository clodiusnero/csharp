using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide answer the following questions by typing and pressing enter.\n\nWhat is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Where do you work?");
            var work = Console.ReadLine();
            Console.WriteLine("What is your age? Use the <yy> format:");
            var age = (Console.ReadLine());
            var born = DateTime.Now.Year - int.Parse(age);
            Console.WriteLine("What is your job title?");
            var title = Console.ReadLine();
            string print = string.Format("\nHello, {0}.\nYou are {1} years old, which means you were born in {2}.\nYou work at {3} as a {4}.", name, age, born, work, title);
            Console.WriteLine(print);
            Console.ReadKey();
        }
    }
}
