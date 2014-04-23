using System;

namespace Payroll
{
    public class AccountFactory
    {
        public IAccount CreateAccount(AccountDetails accountDetails, AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Checkings:
                    return new CheckingsAccount(accountDetails);
                case AccountType.Savings:
                    return new SavingsAccount(accountDetails);
                case AccountType.CheckingsAndSavings:
                    return new CheckingsAndSavingsAccount(accountDetails);
                default:
                    throw new InvalidAccountException();
            }
        }
    }

    public class InvalidAccountException : Exception
    {
    }

    public class Bank
    {
        private AccountFactory factory;
        public int BankNumber { get; set; }

        public Bank(int bankNumber)
        {
            BankNumber = bankNumber;

            this.factory = new AccountFactory();
        }

        public IAccount GetAccountFor(AccountType accountType, int accountNumber)
        {
            var accountDetails = new AccountDetails(this, accountNumber);
            return factory.CreateAccount(accountDetails, accountType);
        }
    }

    public enum AccountType
    {
        Checkings = 100,
        Savings = 200,
        CheckingsAndSavings = 300
    }
}