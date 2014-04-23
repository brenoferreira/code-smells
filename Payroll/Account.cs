namespace Payroll
{
    public interface IAccount
    {
        AccountDetails AccountDetails { get; }

        void Credit(decimal amount);
    }

    public class AccountDetails
    {
        public AccountDetails(Bank bank, int accountNumber)
        {
            Bank = bank;
            AccountNumber = accountNumber;
        }

        public Bank Bank { get; set; }

        public int AccountNumber { get; set; }
    }
}