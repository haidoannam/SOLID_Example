namespace SOLID.Example.SRP.BankingSystem
{
    /// <summary>
    ///  A banking system allows customers to maintain a bank account where they can deposit and withdraw money. 
    ///  Additionally, the bank wants to provide a facility to print a statement of the account’s transaction history.
    /// </summary>

    public class BankAccountRefactor
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public List<string> Transactions = new List<string>();
        public BankAccountRefactor(int accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Transactions.Add($"Withdrew ${amount}. New Balance: ${Balance}");
        }
    }

    public class StatementPrinter
    {
        public void Print(BankAccountRefactor account)
        {
            Console.WriteLine($"Statement for Account: {account.AccountNumber}");
            foreach (var transaction in account.Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
