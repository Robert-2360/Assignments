// TabularOutput.cs
// Exercise 5.22

using System;

class TabularOutput
{
   static void Main(string[] args)
   {
      // initialize variables
      int stopNumber = 5;
      int number = 1;
      string displayFormat = "{0,-7}{1,-9}{2,-10}{3,-11}";

      // display heading
      Console.WriteLine(displayFormat, "N", "10*N", "100*N", "1000*N");
      Console.WriteLine();

      // calculate and display tabular data
      while (number <= stopNumber)
      {
         Console.WriteLine(displayFormat, number, 10 * number, 100 * number, 1000 * number);
         number++;
      }

      //freeze concole window
      Console.ReadLine();
   }
}