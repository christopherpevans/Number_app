using System;

namespace Number_app
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Princeton Evans";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
        }
    }
}
