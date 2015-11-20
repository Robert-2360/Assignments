// Exercise 12.11: Payroll System Modification

using System;

class PieceWorker : Employee
{
   private decimal _wage;
   private int _pieces;

   public decimal Wage
   {
      get
      {
         return _wage;
      }
      set
      {
         if (value >= 0) _wage = value;
         else throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
      }
   }

   public int Pieces
   {
      get
      {
         return _pieces;
      }
      set
      {
         if (value >= 0) _pieces = value;
         else throw new ArgumentOutOfRangeException("Pieces", value, "Pieces must be >= 0");
      }
   }

   public PieceWorker(string first, string last, string ssn, decimal wage, int pieces)
      : base(first, last, ssn)
   {
      Wage = wage;
      Pieces = pieces;
   }

   public override decimal Earnings()
   {
      return Wage * Pieces;
   }

   public override string ToString()
   {
      return string.Format("piece worker: {0}\n{1}: {2:C}; {3}: {4}",
         base.ToString(), "wage", Wage, "pieces", Pieces);
   }
}