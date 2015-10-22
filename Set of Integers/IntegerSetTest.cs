// Exercise 10.8: Set of Integers
// A test class for the IntegerSet class

using System;

class IntegerSetTest
{
   static void Main(string[] args)
   {
      Console.WriteLine("Low Range: {0}", IntegerSet.LOW_RANGE);
      Console.WriteLine("High Range: {0}", IntegerSet.HIGH_RANGE);
      Console.WriteLine();

      try
      {
         // Test for the empty set
         IntegerSet empty = new IntegerSet();
         Console.WriteLine("Empty set: {0} \n", empty);

         // Test InsertElement method is set A
         IntegerSet setA = new IntegerSet();
         setA.InsertElement(0);
         setA.InsertElement(1);
         setA.InsertElement(50);
         setA.InsertElement(100);
         Console.WriteLine("Insert elements in Set A: {0}", setA);

         // Test InsertElement method is set B
         IntegerSet setB = new IntegerSet();
         setB.InsertElement(100);
         setB.InsertElement(99);
         setB.InsertElement(50);
         setB.InsertElement(0);
         Console.WriteLine("Insert elements in Set B: {0} \n", setB);

         // Test DeleteElement method in set A and B
         setA.DeleteElement(100);
         setA.DeleteElement(99); // element not in set
         setB.DeleteElement(0);
         Console.WriteLine("Delete 100 from Set A: {0}", setA);
         Console.WriteLine("Delete 0 from Set B: {0} \n", setB);

         // Test Union method for set A and B
         IntegerSet unionSet = setA.Union(setB);
         Console.WriteLine("Union of A and B: {0} \n", unionSet);

         // Test Intersection method for set A and B 
         IntegerSet intersectSet = setA.Intersection(setB);
         Console.WriteLine("Intersection of A and B: {0} \n", intersectSet);

         // Test IsEqualTo method for set A, B, and C
         IntegerSet setC = new IntegerSet();
         setC.InsertElement(0);
         setC.InsertElement(1);
         setC.InsertElement(50);
         Console.WriteLine("Set A: {0}", setA);
         Console.WriteLine("Set B: {0}", setB);
         Console.WriteLine("Set C: {0}", setC);
         Console.WriteLine("Is Set A equal to Set B? {0}", setA.IsEqualTo(setB));
         Console.WriteLine("Is Set A equal to Set C? {0} \n", setA.IsEqualTo(setC));

         // Test isValid private method
         Console.WriteLine("Try to insert element 999");
         setA.InsertElement(999);
      }

      catch (IndexOutOfRangeException ex)
      {
         Console.WriteLine("*******************************************");
         Console.WriteLine(ex.Message);
         Console.WriteLine("*******************************************");
      }

      // Freeze console window
      Console.ReadLine();
   }
}