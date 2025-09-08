namespace _06_00_BridgePattern;

// Abstraction
public abstract class ElectronicGoods
{
    public IPrice Price { get; set; }
    public string ProductType { get; set; }
    public abstract void Details();

    public void Discount(int percentage)
    {
        Price.GetDiscount(percentage);
    }
}
