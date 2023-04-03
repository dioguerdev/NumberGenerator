using System;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Guess the secret number between 1 and 100!");

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high, try again.");
                }

            } while (guess != secretNumber);

            Console.WriteLine($"Congratulations, you guessed the secret number in {attempts} attempts!");
        }
    }
}