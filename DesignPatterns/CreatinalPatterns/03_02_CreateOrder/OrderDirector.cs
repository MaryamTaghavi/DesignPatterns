namespace _03_02_CreateOrder;

public class OrderDirector
{
    private readonly IOrder _builder;

    public OrderDirector(IOrder builder)
    {
        _builder = builder;
    }

    public Order Build()
    {
        return _builder
            .CreateAddress()
            .CreateDiscount()
            .CreatePayment()
            .CreateOrder();
    }
}