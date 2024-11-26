using System;

class Program
{
    static void Main(string[] args)
   {
        string playAgain; // this Variable to store whether the user wants to play again.

        do
        {
            //  Generate a random magic number between 1 and 100.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Generates a random number between 1 and 100.

            int guess = -1; // Initialize the guess variable to a value that cannot match the magic number.
            int guessCount = 0; // Variable to track the number of guesses made by the user.

            Console.WriteLine("Welcome to the Guess My Number Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

            // this Start a loop that continues until the user guesses the magic number.
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine()); // Convert the user's input to an integer.
                guessCount++; // Increment the guess counter.

                // Provide feedback based on the user's guess.
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher"); // Guess is too low.
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower"); // Guess is too high.
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} attempts."); // Correct guess.
                }
            }

            // Step 3: Ask the user if they want to play again.
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower(); // Convert the input to lowercase for consistent comparison.

        } while (playAgain == "yes"); // Repeat the game as long as the user types "yes".

        // Final message when the user decides to quit.
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}