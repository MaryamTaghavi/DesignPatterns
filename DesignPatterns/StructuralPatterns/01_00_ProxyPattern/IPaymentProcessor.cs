namespace _01_00_ProxyPattern;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
