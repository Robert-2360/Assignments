// Exercise 11.8: Account Inheritance Hierarchy
// A derived class for a banking checking account

using System;

class CheckingAccount : Account
{
   // Declare variable for the fee charged per transaction
   private decimal _transactionFee;
   public decimal TransactionFee
   {
      get { return _transactionFee; }
      private set { _transactionFee = value; }
   }

   // Constructor with balance from account class
   public CheckingAccount(decimal balance, decimal transactionFee)
      : base(balance)
   {
      TransactionFee = transactionFee;
   }

   // Increases balance by given amount minus fee
   public override void Credit(decimal amount)
   {
      base.Credit(amount - TransactionFee);
   }

   // Decreases balance by given amount plus fee
   public override void Debit(decimal amount)
   {
      base.Debit(amount + TransactionFee);
   }
}