namespace _04_01_BankImplements;

public class SamanFactory : PaymentGatewayFactory
{
    public override IPaymentGateway CreatePaymentGateway()
    {
        return new Saman();
    }
}