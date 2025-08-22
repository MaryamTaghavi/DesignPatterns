namespace _04_01_BankImplements;

public abstract class PaymentGatewayFactory
{
    public abstract IPaymentGateway CreatePaymentGateway();
}
