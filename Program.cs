using System;

namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the number guessing game! Remember, three guesses!");
            Random random = new();
            int correctAnswer = random.Next(1, 21);
            

            for (int tryNumber = 0; tryNumber < 3; tryNumber++) {

                Console.WriteLine("Enter your guess from 1 to 20: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess < correctAnswer) {

                    Console.WriteLine("The correct number is larger.");

                }
                else if (guess > correctAnswer) {

                    Console.WriteLine("The correct number is smaller.");

                }
                else if (guess < 1 && guess > 21) {

                    Console.WriteLine("Expecting number from 1 to 20. Keep up.");
                }
                else {

                    Console.WriteLine("Correct! You win!");
                    break;

                }
            }
            Console.WriteLine("The correct number was: " + correctAnswer);
            Console.WriteLine("Game has finished! Thanks for playing!");  
            /*
            Console.WriteLine("Want to play again? y/n");
            Retry = Console.ReadLine();
            */
        }
    }
}