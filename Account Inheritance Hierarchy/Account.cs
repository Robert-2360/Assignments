// Exercise 11.8: Account Inheritance Hierarchy
// A base class for a banking account

using System;

class Account
{
   // Declare variable for the account balance
   private decimal _balance;
   public decimal Balance
   {
      get { return _balance; }
      set
      {
         if (value >= 0.0M) _balance = value;
         else throw new ArgumentOutOfRangeException("AccountBalance",
            value, "Account Balance must be greater than zero.");
      }
   }

   // Constructor
   public Account(decimal balance)
   {
      Balance = balance;
   }

   // Increases balance by given amount
   public virtual void Credit(decimal amount)
   {
      Balance += amount;
   }

   // Decreases balance by given amount or displays message
   public virtual void Debit(decimal amount)
   {
      if (amount > Balance) Console.WriteLine("Debit amount exceeded account balance.");
      else Balance -= amount;
   }
}