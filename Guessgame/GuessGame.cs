using System;

namespace GuessGame
{
    class Guess
    {
        public static void Main(string[] args)
        {
            string playAgain;

            do
            {
                int guess = 0;
                Random random = new Random();
                int randomNumber = random.Next(0, 51);
                int count = 0;

                Console.WriteLine("Welcome to the number guessing game!");
                Console.WriteLine("Guess a number between 0 and 50.");

                while (count < 5)
                {
                    Console.Write("What number are you thinking of? ");
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess < randomNumber)
                        {
                            Console.WriteLine("Too low!!");
                        }
                        else if (guess > randomNumber)
                        {
                            Console.WriteLine("Too high!!");
                        }
                        else
                        {
                            Console.WriteLine("That is correct!");
                            break;
                        }

                        count++;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }

                if (count == 5 && guess != randomNumber)
                {
                    Console.WriteLine("You have run out of chances.");
                    Console.WriteLine("The correct number was " + randomNumber);
                }

                Console.Write("Would you like to play again? (Y/N): ");
                playAgain = Console.ReadLine();

            } while (playAgain != "N" && playAgain != "n");

            Console.WriteLine("Thanks for playing!");
        }
    }
}