namespace _04_01_BankImplements;

public class Mellat : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} with Mellat");
    }
}
