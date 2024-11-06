namespace StrategyPatternExample;

public class PaymentContext
{
    private IPayment _payment;

    public void SetPayment(IPayment payment)
    {
        _payment = payment;
    }
    
    public void ProcessPayment(decimal amount)
    {
        _payment?.Pay(amount);
    }

}