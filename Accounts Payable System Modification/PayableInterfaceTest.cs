// Exercise 12.12: Accounts Payable System Modification

// Fig. 12.15: PayableInterfaceTest.cs
// Tests interface IPayable with disparate classes.
using System;

//Grade 10/10 - Nice Job
public class PayableInterfaceTest
{
   public static void Main(string[] args)
   {
      // create six-element IPayable array
      IPayable[] payableObjects = new IPayable[6];

      // populate array with objects that implement IPayable
      payableObjects[0] = new Invoice("01234", "seat", 2, 375.00M);
      payableObjects[1] = new Invoice("56789", "tire", 4, 79.95M);
      payableObjects[2] = new SalariedEmployee("John", "Smith",
         "111-11-1111", 800.00M);



      /***** Modified code for assignment *****/

      // Add three new payable objects
      payableObjects[3] = new HourlyEmployee("Robert", "Millsaps", "222-22-2222", 12.5M, 20M);
      payableObjects[4] = new CommissionEmployee("Albert", "Einstein", "333-33-3333", 1000M, 0.314159M);
      payableObjects[5] = new BasePlusCommissionEmployee("Bill", "Gates", "444-44-4444", 1000M, 0.314159M, 1000000M);

      // Iterate over all payable objects
      foreach (IPayable currentPayable in payableObjects)
      {
         // Output string representation
         Console.WriteLine(currentPayable);

         // Increase base salary by 10% for Base Plus Commission Employee
         if (currentPayable is BasePlusCommissionEmployee)
         {
            BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentPayable;
            employee.BaseSalary *= 1.10M;
            // Output new base salary
            Console.WriteLine("new base salary with 10% increase is: {0:C}", employee.BaseSalary);
         }

         // Output payment for each payable object
         Console.WriteLine("payment due: {0:C}", currentPayable.GetPaymentAmount());
         Console.WriteLine();
      }

      // Freeze console window
      Console.ReadLine();

      /***** End Modified code for assignment *****/




   } // end Main
} // end class PayableInterfaceTest

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
 **************************************************************************/