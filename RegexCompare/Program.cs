using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Ch04_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                WriteLine("Enter a regular expression (press ENTER to use the default regex): ");
                string defaultRegex = @"^\w[a-z]+$";
                Regex rgx;

                if (ReadKey().Key == ConsoleKey.Enter)
                {
                    rgx = new Regex(defaultRegex);
                }
                else
                {
                    string userRegex = ReadLine();
                    rgx = new Regex(userRegex);
                }

                WriteLine($"The regular expression you have chosen is: {rgx}");

                Write("Enter some input: ");
                string userInput = ReadLine();
                if (rgx.IsMatch(userInput))
                {
                    WriteLine("They match!");
                }
                else
                {
                    WriteLine("They don't match, try again?");
                }

                WriteLine("Would you like to play again? Press ESC to end or any other key to try again.");
                var playAgain = ReadKey();
                if (playAgain.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }

            } while (exit == false);

            Environment.Exit(0);
        }
    }
}