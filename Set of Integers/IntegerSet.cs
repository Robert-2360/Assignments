// Exercise 10.8: Set of Integers
// Represents a set of integers from 0 to 100 by setting each element to true or false

using System;
//Grade: 10
//Observations
//You have some unecessary complication with your _LOW_RANGE and _HIGH_RANGE usage.  They are being set in the constructor and then used to initialize the size of the ArraySet which is fine, except the rangess
//are hardcoded in the constructor as 0-100, so the code on line 17 is more complex then it needs to be when the values are hardcoded anyway.You should always avoid unecessary complexity, if you want to use 
//a configurable _LOW_RANGE and _HIGH_RANGE then you should default them but use the properites in the constructor
class IntegerSet
{
   // Declare class read only constants
   private readonly int _LOW_RANGE;
   public int LOW_RANGE
   {
      get { return _LOW_RANGE; }
   }

   private readonly int _HIGH_RANGE;
   public int HIGH_RANGE
   {
      get { return _HIGH_RANGE; }
   }

   // Declare class variables
   private bool[] _arraySet;
   public bool[] ArraySet
   {
      get { return _arraySet; }
      private set { _arraySet = value; }
   }

   // Constructor: Initialize read only constants, Set all elements to false
   public IntegerSet()
   {
      _LOW_RANGE = 0;
      _HIGH_RANGE = 100;
      ArraySet = new bool[HIGH_RANGE - LOW_RANGE + 1];
      for (int i = LOW_RANGE; i <= HIGH_RANGE; i++) ArraySet[i] = false;
   }

   // ToString method
   public override string ToString()
   {
      string result = "";
      for (int i = LOW_RANGE; i <= HIGH_RANGE; i++)
      {
         if (ArraySet[i]) result += i + " ";
      }
      if (result == "") result = "---";
      return result;
   }

   // Return true if argument is inside range bonudaries
   private bool isValid(int i)
   {
      return (LOW_RANGE <= i) && (i <= HIGH_RANGE);
   }

   // Sets a given element to true
   public void InsertElement(int k)
   {
      if (!isValid(k)) throw new IndexOutOfRangeException();
      ArraySet[k] = true;
   }

   // Sets a given element to false
   public void DeleteElement(int m)
   {
      if (!isValid(m)) throw new IndexOutOfRangeException();
      ArraySet[m] = false;
   }

   // Returns an IntegerSet where each element is true if it true in either or both given sets
   public IntegerSet Union(IntegerSet that)
   {
      IntegerSet resultSet = new IntegerSet();
      for (int i = LOW_RANGE; i <= HIGH_RANGE; i++)
      {
         if (this.ArraySet[i] || that.ArraySet[i]) resultSet.InsertElement(i);
      }
      return resultSet;
   }

   // Returns an IntegerSet where each element is true only if it true in both given sets
   public IntegerSet Intersection(IntegerSet that)
   {
      IntegerSet resultSet = new IntegerSet();
      for (int i = LOW_RANGE; i <= HIGH_RANGE; i++)
      {
         if (this.ArraySet[i] && that.ArraySet[i]) resultSet.InsertElement(i);
      }
      return resultSet;
   }

   // Returns true if every element in both given set have the same value
   public bool IsEqualTo(IntegerSet that)
   {
      bool result = true;
      for (int i = LOW_RANGE; i <= HIGH_RANGE; i++)
      {
         if (this.ArraySet[i] != that.ArraySet[i])
         {
            result = false;
            break;
         }
      }
      return result;
   }
}