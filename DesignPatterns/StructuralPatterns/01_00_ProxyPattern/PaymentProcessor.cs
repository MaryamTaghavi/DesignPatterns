namespace _01_00_ProxyPattern;

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of ${amount}");
        // کد واقعی تراکنش بانک اینجا اجرا می‌شه
    }
}
