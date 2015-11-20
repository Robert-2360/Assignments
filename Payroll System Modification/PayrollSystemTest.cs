// Exercise 12.11 Solution: PayrollSystemTest.cs
// Employee hierarchy test program.
using System;

public class PayrollSystemTest
{
   public static void Main( string[] args )
   {
      // create five-element Employee array
      Employee[] employees = new Employee[ 5 ];

      // initialize array with Employees
      employees[ 0 ] = new SalariedEmployee( "John", "Smith",
         "111-11-1111", 800M );
      employees[ 1 ] = new HourlyEmployee( "Karen", "Price",
         "222-22-2222", 16.75M, 40M );
      employees[ 2 ] = new CommissionEmployee( "Sue", "Jones",
         "333-33-3333", 10000M, .06M );
      employees[ 3 ] = new BasePlusCommissionEmployee( "Bob", "Lewis",
         "444-44-4444", 5000M, .04M, 300M );


      // Added employee for Exercise 12.11
      employees[4] = new PieceWorker("Robert", "Millsaps", "555-55-5555", 1.25M, 100);



      Console.WriteLine( "Employees processed polymorphically:\n" );

      // generically process each element in array employees
      foreach ( var currentEmployee in employees )
      {
         Console.WriteLine( currentEmployee ); // invokes ToString
         Console.WriteLine( "earned {0:C}\n", 
            currentEmployee.Earnings() );
      } // end foreach
   } // end Main
} // end class PayrollSystemTest

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
