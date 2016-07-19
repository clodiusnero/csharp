using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
	    class Logger
    {
        public List<string> LogPosts { get; private set; }

        public void Log(string message)
        {
            LogPosts.Add(message);

        }

        public Logger()
        {
            LogPosts = new List<string>();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();

            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("Third post");

            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}