// PythagoreanTriples.cs
// Exercise 6.21
// Calculate a set of Pythagorean Triples up to 500 using a brute force method

using System;

//Grade 10/10 - Great job, and I like that you compute the squares in the outer loops so that it is done as few times as possible.

public class PythagoreanTriples
{
   public static void Main(string[] args)
   {
      // initialize constants
      const int STOP_NUMBER = 500;
      const string FORMAT = "{0,4}: ({1,3},{2,4},{3,4})   ";
      const int NUMBER_OF_COLUMNS = 3;

      // initialize variables
      int count = 0;

      // loop using side1
      for (int side1 = 1; side1 <= STOP_NUMBER; side1++)
      {
         int side1Squared = side1 * side1;

         // loop using side2
         for (int side2 = 1; side2 <= STOP_NUMBER; side2++)
         {
            int side2Squared = side2 * side2;

            // loop using hypotenuse
            for (int hypotenuse = 1; hypotenuse <= STOP_NUMBER; hypotenuse++)
            {
               int hypotenuseSquared = hypotenuse * hypotenuse;

               // test for a Pythagorean Triple
               if (side1Squared + side2Squared == hypotenuseSquared)
               {
                  count++;
                  Console.Write(FORMAT, count, side1, side2, hypotenuse);

                  //display data on a new line
                  if (count % NUMBER_OF_COLUMNS == 0)
                  {
                     Console.WriteLine();
                  }
               }
            }
         }
      }

      // freeze console window
      Console.ReadLine();
   }
}