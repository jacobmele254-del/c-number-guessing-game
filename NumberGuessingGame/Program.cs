using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Ask user to choose difficulty:
            Console.WriteLine("Choose difficulty: (E)asy, (M)edium, (H)ard");
            string choice = Console.ReadLine() ?? "M";
            choice = choice.ToUpper();

            int min = 1;
            int maxNumber;
            int maxAttempts;

            if (choice == "E")
            {
                maxNumber = 50;
                maxAttempts = 10;
            }
            else if (choice == "H")
            {
                maxNumber = 200;
                maxAttempts = 5;
            }
            else // default to medium
            {
                maxNumber = 100;
                maxAttempts = 7;
            }

            int guess = 0;
            int guesses = 0;
            int max = maxNumber;
            int number = random.Next(min, max + 1);

            Console.Clear();
            Console.WriteLine("=== NUMBER GUESSING GAME ===");
            Console.WriteLine($"Difficulty: {choice}. Guess the number between {min} and {max}! You have {maxAttempts} attempts.");

            while (guess != number && guesses < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    continue;
                }

                guesses++;

                if (guess > number)
                    Console.WriteLine("Too high! Try again.");
                else if (guess < number)
                    Console.WriteLine("Too low! Try again.");
                else
                    Console.WriteLine($"🎉 Correct! You guessed it in {guesses} attempt(s).");
            }

            if (guess != number)
                Console.WriteLine($"Out of attempts! The number was {number}.");

            Console.WriteLine();
            Console.Write("Would you like to play again? (Y/N): ");
            string response = Console.ReadLine() ?? "";
            response = response.ToUpper();
            playAgain = (response == "Y");

            Console.Clear();
        }

        Console.WriteLine("\nThanks for playing! Goodbye 👋");
    }
}

