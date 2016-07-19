using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_12
{
    class Logger : ILogger
    {
        public List<string> LogPosts { get; set; }

        public void Log(string message)
        {
            LogPosts.Add(message);
        }

        public Logger()
        {
            LogPosts = new List<string>();
        }
    }

    public interface ILogger
    {
        List<string> LogPosts { get; set; }
        void Log(string message);
    }


    class LogApplication
    {
        private ILogger _logger;

        public LogApplication(ILogger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            string userInput;
            do
            {
                Console.Clear();
                DisplayMenu();
                userInput = Console.ReadLine().ToUpper();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Message: ");
                        var message = Console.ReadLine();
                        _logger.Log(message);
                        Console.WriteLine("\nMessage added. Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        foreach (var item in _logger.LogPosts)
                        {
                            Console.WriteLine("Message: {0}", item);
                        }
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (userInput != "EXIT");
            if (userInput == "EXIT")
                Environment.Exit(0);
        }

        private void DisplayMenu()
        {
            Console.Write("Kristofers Logger<R>.\n\nThis program provides features for logging.\n\nType EXIT to quit Logger(feature not present while adding Message to Log).\n\n1: Add Message\n2: Print Log\n\nWhat would you like to do? ");
        }

        static void Main(string[] args)
        {
            var logger = new Logger();
            var application = new LogApplication(logger);
            application.Run();
        }
    }
}