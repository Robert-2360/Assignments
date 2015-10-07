// Exercise 7.30: Guess the Number Game
// User tries to guess a randomly generated number.

using System;

public class GuessTheNumberGame
{
   public static void Main(string[] args)
   {
      // initial constants
      const int LOW_RANGE = 1;
      const int HIGH_RANGE = 1000;
      
      // initial variables
      string guessPrompt = "Guess a number between " + LOW_RANGE + " and " + HIGH_RANGE + ": ";
      bool playAgain = true;
      Random random = new Random();

      // play again loop
      while (playAgain)
      {
         // initial variable
         int secretNumber = random.Next(LOW_RANGE, HIGH_RANGE + 1);
         int count = 1; // count the number of guesses

         // game loop
         while (true)
         {
            // input prompt
            Console.Write(guessPrompt);
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            // check if guess is correct then display result
            if (guessedNumber == secretNumber)
            {
               Console.WriteLine("Congratulations. You guessed the number!");
               Console.WriteLine("It took you {0} guess(es)", count);
               Console.WriteLine();
               break;
            }

            // check if guess is too low or too high then display result
            if (guessedNumber < secretNumber)
            {
               Console.WriteLine("Too low. Try again.");
            }
            else
            {
               Console.WriteLine("Too high. Try again.");
            }
            Console.WriteLine();

            // increment counter
            count++;
         }

         // play again prompt
         Console.WriteLine("Do you want to play again?");
         Console.WriteLine("Press Y or y for a new game.");
         string reply = Console.ReadLine();
         Console.WriteLine();

         // test user's response
         if (reply != "Y" && reply != "y") playAgain = false;
      }

      // display final message
      Console.WriteLine();
      Console.WriteLine("Thank you for playing!!");

      // freeze console window
      Console.ReadLine();
   }
}
