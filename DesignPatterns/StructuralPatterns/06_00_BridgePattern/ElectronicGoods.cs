namespace _06_00_BridgePattern;

// Abstraction
public abstract class ElectronicGoods
{
    public IPrice Price;
    public string type;
    public double cost;
    public string ProductType { get; set; }

    public ElectronicGoods (IPrice Price)
    {
        this.Price = Price;
    }

    public void Details()
    {
        Price.DisplayDetails(type, cost);
    }

    public void Discount(int percentage)
    {
        Price.GetDiscount(percentage);
    }
}
