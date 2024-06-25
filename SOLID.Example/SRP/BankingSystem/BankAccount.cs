namespace SOLID.Example.SRP.BankingSystem
{
    /// <summary>
    ///  A banking system allows customers to maintain a bank account where they can deposit and withdraw money. 
    ///  Additionally, the bank wants to provide a facility to print a statement of the account’s transaction history.
    /// </summary>

    /// <summary>
    /// Violation of SRP:
    /// Transaction operations.
    /// Printing the transaction statement.
    /// </summary>

    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
        private List<string> Transactions = new List<string>();
        public BankAccount(int accountNumber)
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

        // Violation of SRP
        public void PrintStatement()
        {
            Console.WriteLine($"Statement for Account: {AccountNumber}");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }

    }
}
