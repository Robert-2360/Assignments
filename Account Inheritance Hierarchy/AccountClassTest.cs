// Exercise 11.8: Account Inheritance Hierarchy
// A test program for Account, SavingAccount, and CheckingAccount classes

using System;

class AccountClassTest
{
   static void Main(string[] args)
   {
      /* 
       *      Account Class Test
       */
      Console.WriteLine("**********     Account Class Test     **********");
      Console.WriteLine("");

      // Create new account
      decimal openningAmount = 65.12M;
      Account account = new Account(openningAmount);

      // Display openning balance
      Console.WriteLine("Openning balance for account is {0:C}", account.Balance);
      Console.WriteLine("");

      // Test withdraw amount exceeds balance
      decimal excessWithdraw = 1000M;
      account.Debit(excessWithdraw);
      Console.WriteLine("Try to withdraw {0:C} from account. Unchanged balance is {1:C}",
         excessWithdraw, account.Balance);
      Console.WriteLine("");

      // Test a proper withdraw amount
      decimal properWithdraw = 5.12M;
      account.Debit(properWithdraw);
      Console.WriteLine("Withdraw {0:C} from account. New balance is {1:C}", properWithdraw, account.Balance);
      Console.WriteLine("");

      // Test deposit into account
      decimal deposit = 0.01M;
      account.Credit(deposit);
      Console.WriteLine("Deposit {0:C} into account. New balance is {1:C}", deposit, account.Balance);
      Console.WriteLine("");

      // Test creating account with a negative openning balance
      openningAmount = -10M;
      Console.WriteLine("Try to create new account with {0:C}", openningAmount);
      try
      {
         Account negative = new Account(openningAmount);
      }
      catch (ArgumentOutOfRangeException e)
      {
         Console.WriteLine(e.Message);
      }
      finally
      {
         Console.WriteLine("");
      }


      /*
       *      SavingAccount Class Test
       */
      Console.WriteLine("");
      Console.WriteLine("**********     SavingAccount Class Test     **********");
      Console.WriteLine("");

      // Create new Saving Account
      decimal interestRate = 0.05M;
      openningAmount = 800M;
      SavingsAccount savingsAccount = new SavingsAccount(openningAmount, interestRate);

      // Display openning balance
      Console.WriteLine("Openning balance for savings account is {0:C}", savingsAccount.Balance);
      Console.WriteLine("Having an interest rate of {0:P}", savingsAccount.InterestRate);
      Console.WriteLine("");

      // Test deposit into account (from Account Class)
      deposit = 100M;
      savingsAccount.Credit(deposit);
      Console.WriteLine("Deposit {0:C} into savings account. New balance is {1:C}",
         deposit, savingsAccount.Balance);
      Console.WriteLine("");

      // Test calculate interest
      decimal interestAmount = savingsAccount.CalculateInterest();
      Console.WriteLine("Calculated amount from {0:P} interest is {1:C}", interestRate ,interestAmount);
      Console.WriteLine("");


      /*
       *      CheckingAccount Class Test
       */
      Console.WriteLine("");
      Console.WriteLine("**********     CheckingAccount Class Test     **********");
      Console.WriteLine("");

      // Create new Checking Account
      decimal transactionFee = 0.02M;
      openningAmount = 500M;
      CheckingAccount checkingAccount = new CheckingAccount(openningAmount, transactionFee);

      // Display openning balance
      Console.WriteLine("Openning balance for checking account is {0:C}", checkingAccount.Balance);
      Console.WriteLine("Having a transaction fee of {0:C}", checkingAccount.TransactionFee);
      Console.WriteLine("");

      // Test deposit into checking account (overrides Account Class)
      deposit = 100M;
      checkingAccount.Credit(deposit);
      Console.WriteLine("Deposit {0:C} into checking account. New balance is {1:C}",
         deposit, checkingAccount.Balance);
      Console.WriteLine("");

      // Test excess withdraw from checking account
      excessWithdraw = 1000M;
      checkingAccount.Debit(excessWithdraw);
      Console.WriteLine("Try to withdraw {0:C} from checking account. Unchanged balance is {1:C}",
         excessWithdraw, checkingAccount.Balance);
      Console.WriteLine("");

      // Test a proper withdraw amount from checking account
      properWithdraw = 99M;
      checkingAccount.Debit(properWithdraw);
      Console.WriteLine("Withdraw {0:C} from checking account. New balance is {1:C}",
         properWithdraw, checkingAccount.Balance);
      Console.WriteLine("");



      // Freeze console window
      Console.ReadLine();
   }
}