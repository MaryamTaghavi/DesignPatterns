namespace _04_01_BankImplements;

public class Saman : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} by Saman");
    }
}
