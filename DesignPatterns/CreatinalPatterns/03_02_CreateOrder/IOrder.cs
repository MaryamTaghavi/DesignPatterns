namespace _03_02_CreateOrder;

public interface IOrder
{
    double CreateDiscount();
    string CreateAddress();
    double CreatePayment();
    Order CreateOrder();
}
