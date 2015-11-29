// Exercise 8.17: Dice Rolling
// Roll two dice 36,000 times and tally the results

using System;
//Grade: 10/10
public class DiceRolling
{
   public static void Main(string[] args)
   {
      // Initialize constants
      const int FINAL_COUNT = 36000;
      const int SIZE = 13; // for tally array

      // Initialize variables
      Random random = new Random();
      int counter = 0;
      int[] tally = new int[SIZE];

      int[] expectedTally = { 0, 0, 1000, 2000, 3000, 4000, 5000, 6000, 5000, 4000, 3000, 2000, 1000 };

      // Roll dice 36,000 times
      while (counter < FINAL_COUNT)
      {
         // roll dice once and sum total
         int die1 = RollDie(random);
         int die2 = RollDie(random);
         int sum = die1 + die2;

         // tally result
         tally[sum]++;

         // increment counter
         counter++;
      }

      // Display tally results
      DisplayTally(tally, expectedTally);

      // Freeze console window
      Console.ReadLine();
   }


   // Return a single die roll
   public static int RollDie(Random r)
   {
       //You can use Next(1,7) to avoid the addition
      return 1 + r.Next(6);
   }


   // Display tally results
   // Note: The sum of the differences is always zero.
   //       It took me a little while to figure out why this is so.
   //       Hint: What would be the total sum of the other columns?
   public static void DisplayTally(int[] array1, int[] array2)
   {
      // initialize variables
      string FORMAT = "{0, 5}{1, 11}{2, 13}{3, 15}";
      int totalDifference = 0;

      // display results
      Console.WriteLine(FORMAT, "Sum", "Tally", "Expected", "Difference");
      for (int i = 2; i <= 12; i++)
      {
         int difference = array1[i] - array2[i];
         totalDifference += difference;
         Console.WriteLine(FORMAT, i, array1[i], array2[i], difference);
      }
      Console.WriteLine();
      Console.WriteLine("{0, 40}{1, 4}", "The sum of the differences is:", totalDifference);
   }
}