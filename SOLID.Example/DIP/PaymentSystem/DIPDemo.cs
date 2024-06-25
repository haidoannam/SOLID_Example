using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Example.DIP.PaymentSystem
{
    /// <summary>
    /// u might have multiple payment methods (Credit Card, PayPal, etc.), 
    /// and the system should be flexible enough to handle any new payment methods in the future.
    /// </summary>
    public class CreditCard
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }
    public class PaymentProcessor
    {
        public void ExecutePayment(decimal amount)
        {
            var creditCard = new CreditCard();
            creditCard.ProcessPayment(amount);
        }
    }

    /// Problem issue
    /// This design tightly couples the PaymentProcessor to the CreditCard class. 
    /// What if we want to add PayPal or any other payment method in the future?
}
