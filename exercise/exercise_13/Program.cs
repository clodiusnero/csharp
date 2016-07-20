using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Please enter your date of birth (yyyy/MM/dd): ");
            var queryOfBirth = Console.ReadLine();
            var birthDate = DateTime.ParseExact(queryOfBirth, "yyyy/MM/dd",
                                  CultureInfo.InvariantCulture);

            var today = DateTime.Now;

            int age = today.Year - birthDate.Year;
            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age = age - 1;
            }

            var nextBirthday = birthDate.AddYears(age + 1) - DateTime.Now;

            Console.WriteLine("Hello, {0}.\nYou are {1} years old, and will turn {2} in {3} days.\nYour 100th birthday will be on a {4}.", name, age, (age + 1), nextBirthday.Days, (birthDate.AddYears(100).DayOfWeek));
            Console.ReadKey();
        }
    }
}
