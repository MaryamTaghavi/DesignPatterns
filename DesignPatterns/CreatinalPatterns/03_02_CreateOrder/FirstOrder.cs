namespace _03_02_CreateOrder;

public class FirstOrder : IOrder
{
    Order order;

    public FirstOrder()
    {
        order = new Order();
    }
    public IOrder CreateAddress()
    {
        order.Address = "یزد، مهرآوران";
        return this ;
    }

    public IOrder CreateDiscount()
    {
        order.Discount = 2.3;
        return this;
    }

    public IOrder CreatePayment()
    {
        order.Payment = 1500000;
        return this;
    }

    public Order CreateOrder()
    {
        return order;
    }
}
