using _04_01_BankImplements;

Console.WriteLine("*** Pay with saman gateway ***");
PaymentGatewayFactory samanFactory = new SamanFactory();
IPaymentGateway saman = samanFactory.CreatePaymentGateway();
saman.Pay(1_000_000);

Console.WriteLine("*** Pay with zarinpal gateway ***");
PaymentGatewayFactory zarinpalFactory = new ZarinpalFactory();
IPaymentGateway zarinpal = zarinpalFactory.CreatePaymentGateway();
zarinpal.Pay(2_000_000);

Console.WriteLine("*** Pay with mellat gateway ***");
PaymentGatewayFactory mellatFactory = new MellatFactory();
IPaymentGateway mellat = mellatFactory.CreatePaymentGateway();
mellat.Pay(60_000_000);