namespace _04_01_BankImplements;

public class MellatFactory : PaymentGatewayFactory
{
    public override IPaymentGateway CreatePaymentGateway()
    {
        return new Mellat();
    }
}
