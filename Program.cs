using System;

namespace Number_app
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo

            GreetUser(); //Ask user for name and greet

            while (true)
            {
                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 11);

                // Set guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure user enters number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a number");

                        //Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print Success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Display App info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Princeton Evans";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Start Here

            // Reset text color
            Console.ResetColor();
        }

            //Ask user name and greet
            static void GreetUser()
            {
                // Ask users name
                Console.WriteLine("What is your name?");

                // Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let's play a game...", inputName);
            }
        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user input must be number
            Console.WriteLine(message);
            // Start Here

            // Reset text color
            Console.ResetColor();
        }
    }
}
