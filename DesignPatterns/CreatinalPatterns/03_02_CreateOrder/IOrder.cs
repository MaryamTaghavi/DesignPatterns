namespace _03_02_CreateOrder;

public interface IOrder
{
    IOrder CreateDiscount();
    IOrder CreateAddress();
    IOrder CreatePayment();
    Order CreateOrder();
}
