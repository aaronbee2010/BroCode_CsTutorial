// 17. Number guessing game
using System;

namespace NumberGuessingGame {
    class Program {
        static void Main(string[] args) {
            Random randomObject = new Random();
            bool playAgain = true;

            int maxAttempts = 10;
            int lowerBound = 1;
            int upperBound = 100;

            int correctAnswer;

            int guessCount = 1;
            int currentGuess = -1;

            string response;

            while (playAgain) { // Specifying a bool x on its own within the parentheses is the same as specifying "x == true"
                
                Console.Write(     $"You have {maxAttempts} attempts to guess a " );
                Console.WriteLine( $"number between {lowerBound} and {upperBound}.\n" );

                correctAnswer = randomObject.Next(lowerBound, upperBound + 1);

                while (guessCount <= maxAttempts) {   
                    if (guessCount == maxAttempts) {
                        Console.WriteLine("Careful! You're on your last guess!");
                    }

                    Console.Write( $"Guess {guessCount}: " );
                    currentGuess = Convert.ToInt32(Console.ReadLine());

                    if (currentGuess == correctAnswer) {
                        break;
                    } else if (currentGuess < correctAnswer) {
                        Console.WriteLine("Too low!");
                    } else if (currentGuess > correctAnswer) {
                        Console.WriteLine("Too high!");
                    }

                    guessCount++;
                }

                if (currentGuess == correctAnswer) {
                    Console.WriteLine($"Congratulations! You guessed the correct answer in {guessCount} attempts!");
                } else {
                    Console.WriteLine($"Sorry! The correct answer was {correctAnswer}!");
                }

                Console.WriteLine("Would you like to play again? [y/n] ");
                response = Console.ReadLine();
                if (response.ToLower() != "y") {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing! ... I guess");
                    Console.WriteLine("*** Ba Dun Tss ***");
                }  
            }

            Console.ReadKey();
        }
    }
}
