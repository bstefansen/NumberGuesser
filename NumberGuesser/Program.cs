using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user its not anumber
                        Console.WriteLine("Please enter an actual number");

                        // Reset text color
                        Console.ResetColor();

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user its a wrong guess
                        Console.WriteLine("Wrong Number, please try again");

                        // Reset text color
                        Console.ResetColor();
                    }
                }

                // Output success message
                //Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell user its the right number
                Console.WriteLine("Correct! The right answer was {0}", correctNumber);

                // Reset text color
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Blake Stefansen";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users nanme and greet
        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
    }
}
