
namespace SOLID.Example.DIP.PaymentSystem.WithDIP
{
    /// <summary>
    /// By decoupling the PaymentProcessor from specific implementations, 
    /// it becomes simpler to add or modify payment methods without altering the PaymentProcessor class. 
    /// This takes advantage of the Dependency Inversion Principle, which makes the system more flexible and maintainable.
    /// </summary>

    //Interface for Payment
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    //Concrete Implementations
    public class CreditCard : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }

    //Our PaymentProcessor class will now depend on the abstraction
    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
