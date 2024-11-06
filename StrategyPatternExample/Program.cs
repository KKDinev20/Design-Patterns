namespace StrategyPatternExample;

class Program
{
    static void Main(string[] args)
    {
        PaymentContext paymentContext = new PaymentContext();

        paymentContext.SetPayment(new CreditCardPayment());
        paymentContext.ProcessPayment(100);

        paymentContext.SetPayment(new PayPalPayment());
        paymentContext.ProcessPayment(200);

        paymentContext.SetPayment(new GooglePayPayment());
        paymentContext.ProcessPayment(300);
    }
}
