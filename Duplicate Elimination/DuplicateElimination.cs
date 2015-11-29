// Exercise 8.12: Duplicate Elimination
// Eliminate duplicate entries from console input
// Assumptions:
//    Entries are all integers from 10 to 100 inclusive.
//    No more than five unique numbers are saved.
//    The array is not sorted.

//Grade 9/10
//Program does not validate numbers between 10 and 100
//Requirements state that 5 numbers should be read in with only the exclusive numbers displayed, your program allows input of more than 5 numbers if duplicate numbers are added.
//Requirements specify that the smallest possible array should be used, the last number does not need to be stored, so an array of size 4 can be used instead of 5.

using System;

//Grade 9/10
//Program does not validate numbers between 10 and 100
//Requirements state that 5 numbers should be read in with only the exclusive numbers displayed, your program allows input of more than 5 numbers if duplicate numbers are added.
//Requirements specify that the smallest possible array should be used, the last number does not need to be stored, so an array of size 4 can be used instead of 5.
public class DuplicateElimination
{
   public static void Main(string[] args)
   {
      // initialize constants
      const int SIZE = 5;

      // initialize varibles
      int[] numbers = new int[SIZE];

      // loop until numbers array is "full"
      while (numbers[SIZE-1] == 0)
      {
         // User prompt
         Console.Write("Enter a number between 10 and 100, inclusive: ");
         int number = Convert.ToInt32(Console.ReadLine());

         AddNumberIfUnique(number, numbers);

         //Display results
         Console.Write("Unique numbers entered so far: ");
         DisplayArray(numbers);
         Console.WriteLine();
      }

      // Display final results
      Console.WriteLine("You have entered {0} unique numbers.", SIZE);
      Console.Write("Here they are again: ");
      DisplayArray(numbers);

      // Freeze console window
      Console.ReadLine();
   }


   // Display the numbers in the array, stop at first zero
   public static void DisplayArray(int[] anArray)
   {
      for (int i = 0; i < anArray.Length; i++)
      {
         if (anArray[i] != 0) Console.Write("{0}  ", anArray[i]);
         else break;
      }
      Console.WriteLine();
   }


   // Include the given number in the array only if it is unique
   public static void AddNumberIfUnique(int aNumber, int[] anArray)
   {
      for (int i = 0; i < anArray.Length; i++)
      {
         // Check if the array slot is zero, this means the number is unique
         if (anArray[i] == 0)
         {
            anArray[i] = aNumber;
            break;
         }

         // Check if the number is a duplicate entry, if so stop looking
         if (anArray[i] == aNumber) break;
      }
   }
}