using System;

namespace Payroll
{
    //account type 300
    public class CheckingsAndSavingsAccount : IAccount
    {
        public CheckingsAndSavingsAccount(AccountDetails accountDetails)
        {
            AccountDetails = accountDetails;
        }

        public AccountDetails AccountDetails { get; private set; }

        public void Credit(decimal amount)
        {
            Console.WriteLine("Credit made on account {0} from bank number {1}, in the amount of {2}, from checkings and savings account", AccountDetails.AccountNumber, AccountDetails.Bank.BankNumber, amount);
        }
    }
}