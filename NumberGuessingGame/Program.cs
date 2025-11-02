using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        string response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);
            response = "";

            Console.Clear(); // ✅ Clears previous text for a fresh round
            Console.WriteLine("=== NUMBER GUESSING GAME ===");
            Console.WriteLine($"Guess the number between {min} and {max}!");

            // Loop for guessing
            while (guess != number)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if (guess > number)
                    Console.WriteLine("Too high! Try again.");
                else if (guess < number)
                    Console.WriteLine("Too low! Try again.");
                else
                    Console.WriteLine($"🎉 Correct! You guessed it in {guesses} attempt(s).");
            }

            Console.WriteLine();
            Console.Write("Would you like to play again? (Y/N): ");
            response = Console.ReadLine()!;
            response = response.ToUpper();

            playAgain = (response == "Y");
        }

        Console.WriteLine("\nThanks for playing! Goodbye 👋");
    }
}