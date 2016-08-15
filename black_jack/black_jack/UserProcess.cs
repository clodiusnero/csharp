using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{
    class UserProcess
    {
        static decimal userBalance = 500;
        static decimal userBet;
        static int hands = 1;
        static int wins;
        static int losses;

        public static string dealHand()
        {
            Console.WriteLine("Deal? (y/n)");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("Balance: {0:c2}. Hands: {1}. Wins: {2} . Losses: {3}/n", userBalance, hands, wins, losses);

                if (userBalance == 0)
                {
                    Console.WriteLine("You are bust! Leave the game by pressing Enter. . .");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
         
                do
                {
                    Console.Write("Place your bet: ");

                    if (decimal.TryParse(Console.ReadLine(), out userBet) && userBet <= userBalance && userBet > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Bet: {0:c2}", userBet);
                        break;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Only use numbers, e.g. 1, 2, 3. No letters or other signs allowed.");
                        userInput = Console.ReadLine();
                    }

                } while (true);
            }

            else
            {
                Environment.Exit(0);
            }
        
            return userInput;
        }
        private static void updateStatistics(string winner)
        {
            userBalance += winner == "user" ? userBet : winner == "dealer" ? -userBet : 0;
            hands += 1;
            wins += winner == "user" ? 1 : 0;
            losses += winner == "dealer" ? 1 : 0;

        }
    }
}
