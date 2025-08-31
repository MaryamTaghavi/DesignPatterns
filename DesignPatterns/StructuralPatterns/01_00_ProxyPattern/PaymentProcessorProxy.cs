namespace _01_00_ProxyPattern;

public class PaymentProcessorProxy : IPaymentProcessor
{
    private readonly PaymentProcessor _realProcessor;
    private readonly bool _isAuthorized;

    public PaymentProcessorProxy(bool isAuthorized)
    {
        _realProcessor = new PaymentProcessor();
        _isAuthorized = isAuthorized;
    }

    public void ProcessPayment(decimal amount)
    {
        if (!_isAuthorized)
        {
            Console.WriteLine("Access denied! User is not authorized to make payments.");
            return;
        }

        Console.WriteLine("Logging: Payment request received");
        _realProcessor.ProcessPayment(amount);
        Console.WriteLine("Logging: Payment processed successfully");
    }
}
