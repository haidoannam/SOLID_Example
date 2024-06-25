
namespace SOLID.Example.LSP.BankAccounts
{
    public class BankAccount
    {
        protected double balance;
        public virtual void Deposit(double amount)
        {
            balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    public class FixedTermDepositAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            throw new InvalidOperationException("Cannot withdraw from a fixed term deposit account until term ends");
        }
    }
}
