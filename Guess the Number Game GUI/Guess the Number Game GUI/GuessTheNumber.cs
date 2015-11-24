// Guess the Number Class
// A class used in Guess the Number Game

using System;

//Grade: 10
//All requirements have been met
class GuessTheNumber
{
   // The number that the user tries to guess
   private int _secretNumber;
   public int SecretNumber
   {
      get { return _secretNumber; }
      set { setSecretNumber(); }
   }

   // Assigns a random number to SecretNumber
   // Resets Counter
   // Note: The user can not set their own SecretNumber
   public void setSecretNumber()
   {
      Random random = new Random();
      _secretNumber = random.Next(LowRange, HighRange + 1);
      Counter = 1;
   }

   public int LowRange { get; set; }
   public int HighRange { get; set; }
   public int Counter { get; set; }

   public GuessTheNumber(int low, int high)
   {
      LowRange = low;
      HighRange = high;
      setSecretNumber();
   }

   // Returns true if user's guess is correct
   public bool isCorrect(int n)
   {
      return n == SecretNumber;
   }

   // Returns true if user's guess is less than SecretNumber
   public bool isLow(int n)
   {
      return n < SecretNumber;
   }

   // Returns true if user's guess is greater than SecretNumber
   public bool isHigh(int n)
   {
      return n > SecretNumber;
   }

   // Returns true if user's current guess is closer that their last guess
   // Note: This should be "initialized" with previous = Int32.MaxValue
   public bool isGettingCloser(int current, int previous)
   {
      return Math.Abs(current - SecretNumber) < Math.Abs(previous - SecretNumber);
   }
}