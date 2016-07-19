using System;

namespace exercise_4
{
    class Account
    {
        private int balance = 10000000; //typiskt studentkonto
        //förstod inte riktigt varför funktioner som Withdraw och Deposit skulle skapas när de fanns i programmet redan. Stoppade dem här istället.
        public void Withdraw() 
        {
            Console.WriteLine("Enter amount: ");
            int amount = int.Parse(Console.ReadLine());

            if (GetBalance >= amount)
            {
                Console.WriteLine("\nWithdrawing {0} SEK from account...\nDone\n\nPress Enter to return", amount);
                GetBalance -= amount;
            }
            else
            {
                Console.WriteLine("\nYou don't have {0} SEK to withdraw", amount);
            }
        }
        public void Deposit()
        {
            Console.WriteLine("\nEnter amount: ");
            int amount = int.Parse(Console.ReadLine());

            GetBalance += amount;
            Console.WriteLine("\nDepositing {0} SEK to account...\nDone\n\nPress Enter to return.", amount);
        }
        public int GetBalance
        {
            get
            {
                return balance;
            }
            set
            {
                if ((value > 0))
                {
                    balance = value;
                }
            }
        }
	}
        class Program
        {
            static void Main(string[] args)
            {
                bool run = true;
                var account = new Account();

                while (run)
                {
                    // Print main menu
                    Console.Clear();
                    Console.WriteLine("Select an option");
                    Console.WriteLine("----------------");
                    Console.WriteLine();
                    Console.WriteLine("a) Withdraw from account");
                    Console.WriteLine("b) Deposit to account");
                    Console.WriteLine("c) Check balance");
                    Console.WriteLine("d) Exit");
                    Console.WriteLine();

                    // Collect user input
                    Console.Write("> ");
                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "a": // The user selected "Withdraw from account"
                        account.Withdraw();
                            break;

                        case "b":
                        account.Deposit();
                            break;

                        case "c":
                            Console.Write("You have {0} SEK on your account\n>", account.GetBalance);
                            break;

                        case "d":
                            run = false;
                            Console.Write("\nBye!");
                            break;
                    }

                    Console.ReadKey();
                }
            }
        }
}