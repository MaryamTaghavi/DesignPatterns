namespace _04_01_BankImplements;

public class Zarinpal : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} by Zarinpal");
    }
}
