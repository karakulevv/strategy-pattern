using StrategyPattern.Interfaces;

namespace StrategyPattern.Strategies;

// Implement Concrete Payment Strategy
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment via Credit Card.");
        // Add specific logic for Credit Card payment processing
    }
}