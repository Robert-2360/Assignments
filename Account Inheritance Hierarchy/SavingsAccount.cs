// Exercise 11.8: Account Inheritance Hierarchy
// A derived class for a banking savings account

using System;

class SavingsAccount : Account
{
   // Declare variable for the interest rate
   // Note: This is expressed as a fraction (For example, 0.05M is a rate of 5%)
   private decimal _interestRate;
   public decimal InterestRate
   {
      get { return _interestRate; }
      private set { _interestRate = value; }
   }

   // Constructor with balance from account class
   public SavingsAccount(decimal balance, decimal interestRate)
      : base(balance)
   {
      InterestRate = interestRate;
   }

   // Returns the amount earned for "this" saving account
   public decimal CalculateInterest()
   {
      return InterestRate * Balance;
   }
}