using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace exercise
{
    class Logger
    {
        public void Log(string message)
        {
            LogPosts.Add(message);

        }
        public List<string> LogPosts { get; private set; }

        public Logger()
        {
            LogPosts = new List<string>();

        }

    }

    public class Employee
    {
        public int ID { get; set; } = 0;
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialNumber { get; set; }
        public string HourWage { get; set; }

        public override string ToString()
        {
            return string.Format("--------------------------------------------{5}ID:{0}{5}Full Name: {1} {2}{5}Social Security Number: {3}{5}Wage: {4}{5}--------------------------------------------{5}", ID, FirstName, LastName, SocialNumber, HourWage, Environment.NewLine);
        }
		
        public Employee(int ID, string firstname, string lastname, string socialnumber, string hourwage)
        {
            ID = 0;
            FirstName = firstname;
            LastName = lastname;
            SocialNumber = socialnumber;
            HourWage = hourwage;
        }
    }

    public class Registry
    {
        public List<Employee> Accounts { get; private set; }

        public Registry()
        {
            Accounts = new List<Employee>();
        }

        public void SearchEmployeesByYear()
        {
            Console.Write("\n\nEnter  Employee SSN, more digits equals narrower result<YYMMDD-XXX>: ");
            var input = Console.ReadLine();
            var query = Accounts.Where(employee => employee.SocialNumber.StartsWith(input)).ToList();

            if (!query.Any())
            {
                Console.WriteLine("\nNo matches, press any key to return to menu.");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMatches");
                Console.ResetColor();
                foreach (Employee employee in query)
                {
                    Console.WriteLine(employee);
                }
                Console.WriteLine("Press any key to continue or go back to menu.");
                Console.ReadKey();
            }

        }

        public void CreateAccount()
        {
            var employee = new Employee(0, "", "", "", "");

            Console.Write("\n\nEnter first name <Name>: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Enter last name <Name>: ");
            employee.LastName = Console.ReadLine();

            Console.Write("Enter Social Security Number<YYMMDD-XXXX>: ");
            employee.SocialNumber = Console.ReadLine();

            Console.Write("Enter wage <XXXkr/h>: ");
            employee.HourWage = Console.ReadLine();

            employee.ID = Accounts.Count + 1;

            Accounts.Add(employee);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n{0} {1}", employee.FirstName, employee.LastName);
            Console.ResetColor();
            Console.Write(" was successfully added to the Registry.\nPress any key to go back to menu.");
            Console.ReadKey();

        }

        public void RemoveAccount()
        {
            Console.Write("\nEnter Employee Social Security Number<XXXXXX-XXXX> to remove: ");

            string warning = "\nYou may only remove employees who are in the registry.\nPress any key to go back to menu.";

            var input = Console.ReadLine();
            var match = Regex.Match(input, @"^\d{6}-\d{4}$"); 
            if (match.Success)
            {
                if (Accounts.Exists(employee => employee.SocialNumber == input))
                {
                    Accounts.RemoveAll(employee => employee.SocialNumber == input);
                    Console.Write("\nEmployee SSN: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}", input);
                    Console.ResetColor();
                    Console.Write(" was successfully deleted. Press any key to go back to menu.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(warning);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine(warning);
                Console.ReadKey();
            }
        }
        public void PrintRegistry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nCurrent Employees");
            Console.ResetColor();
            foreach (Employee employee in Accounts)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("Press any key to continue or go back to menu.");
            Console.ReadKey();
        }
    }

    public class UserProcess
    {
        public void Process()
        {
            var registry = new Registry();

            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                DisplayMenu();
                cki = Console.ReadKey(false);
                string input = cki.KeyChar.ToString();
                switch (input)
                {
                    case "1":
                        registry.CreateAccount();
                        break;

                    case "2":
                        registry.PrintRegistry();
                        registry.RemoveAccount();
                        break;

                    case "3":
                        registry.PrintRegistry();
                        break;

                    case "4":
                        registry.SearchEmployeesByYear();
                        break;
                }


            } while (cki.Key != ConsoleKey.Escape);
        }

        private void DisplayMenu()
        {
            Console.Write("\n------------------\nEmployee Registry\n------------------\nWhat action do you wish to take?\n\n1. Add employee. \n2. Remove employee.\n3. Print Employee Registry.\n4. Search Employee using SSN.\n\nYou may exit by pressing the Escape button at start menu.\n\nYour choice of action: ");
        }
        static void Main(string[] args)
        {
            var user = new UserProcess();
            user.Process();
        }
    }
}