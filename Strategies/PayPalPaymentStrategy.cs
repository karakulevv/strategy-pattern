using StrategyPattern.Interfaces;

namespace StrategyPattern.Strategies;

// Implement Concrete Payment Strategy
public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment via PayPal.");
        // Add specific logic for PayPal payment processing
    }
}