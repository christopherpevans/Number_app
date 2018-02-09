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


            // Write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Set correct number
            int correctNumber = 7;

            // Set guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber) {
                // Get users input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber) 
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;


                    // Write app info
                    Console.WriteLine("Wrong number, please try again");

                    //Reset text color
                    Console.ResetColor();
                }
            }
        }
    }
}
