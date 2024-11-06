namespace StrategyPatternExample;

public class GooglePayPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using GooglePay.");
    }
}