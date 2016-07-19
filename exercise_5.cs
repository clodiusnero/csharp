using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise_5
{

    public class Employee
    {
        public string FirstNamne { get; set; }
        public string LastName { get; set; }
        public string SocialNumber { get; set; }
        public string HourWage { get; set; }
        public void PrintEmployee()
        {
            Console.WriteLine("Full Name: {0} {1}\nSocial Security Number: {2}\nWage: {3}\n", FirstNamne, LastName, SocialNumber, HourWage);
        }

        public Employee(string firstname, string lastname, string socialnumber, string hourwage)
        {
            FirstNamne = firstname;
            LastName = lastname;
            SocialNumber = socialnumber;
            HourWage = hourwage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Johan", "Larsson", "580219-2843", "150kr/h");
            var employee2 = new Employee("Anders", "Lindhamn", "45354-2934", "150kr/h");
            employee1.PrintEmployee();
            employee2.PrintEmployee();
            Console.ReadKey();
        }
    }
}