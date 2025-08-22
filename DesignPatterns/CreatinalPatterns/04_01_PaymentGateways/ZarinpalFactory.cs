namespace _04_01_BankImplements;

public class ZarinpalFactory : PaymentGatewayFactory
{
    public override IPaymentGateway CreatePaymentGateway()
    {
        return new Zarinpal();
    }
}