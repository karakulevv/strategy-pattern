using StrategyPattern.Interfaces;
using StrategyPattern.Processor;
using StrategyPattern.Strategies;

class Program
{
    static void Main(string[] args)
    {
        // Creating different payment strategies
        IPaymentStrategy creditCardPayment = new CreditCardPaymentStrategy();
        IPaymentStrategy paypalPayment = new PayPalPaymentStrategy();

        // Creating the context (PaymentProcessor)
        PaymentProcessor processor = new PaymentProcessor(creditCardPayment);

        // Processing payments using different strategies
        processor.ProcessPayment(); // Using Credit Card payment strategy

        // Changing the payment strategy dynamically
        processor.SetPaymentStrategy(paypalPayment);
        processor.ProcessPayment(); // Using PayPal payment strategy
    }
}