namespace StrategyPatternExample;

public class PayPalPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Paypal");
    }
}