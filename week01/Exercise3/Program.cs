using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);

        // int guess = -1;

        // while (guess != magicNumber)
        // {

        //     Console.Write("What is your guess? ");
        //     string guessInput = Console.ReadLine();
        //     guess = int.Parse(guessInput);

        //     if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Guess is too low. Try again.");
        //     }

        //     else if (guess > magicNumber)
        //     {
        //         Console.WriteLine("Guess is too high. Try again.");
        //     }

        //     else if (guess == magicNumber)
        //     {
        //         Console.WriteLine("You guessed it correctly! Congratulations!");
        //     }
        // }

        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;
    
        while (guess !=magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Guess is too low. Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess is too high. Try again.");
            }
            else
            {
                Console.WriteLine($"You guessed it correctly in {guessCount} tries! Congratulations!");
            }
        }
        Console.Write("Do you want to play again? (yes/no) ");
        playAgain = Console.ReadLine();
        }
        
        Console.WriteLine("Thank you for playing! Goodbye!");

    }

}


