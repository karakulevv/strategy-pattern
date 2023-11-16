using StrategyPattern.Interfaces;

namespace StrategyPattern.Processor;

// Create Context Class
public class PaymentProcessor
{
    private IPaymentStrategy paymentStrategy;

    public PaymentProcessor(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        paymentStrategy = strategy;
    }

    public void ProcessPayment()
    {
        paymentStrategy.ProcessPayment();
    }
}