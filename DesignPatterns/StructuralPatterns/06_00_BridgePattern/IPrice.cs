namespace _06_00_BridgePattern;

// Implementor
// Bridge
public interface IPrice
{
    void DisplayDetails(string product, double price);

    void GetDiscount(int percentage);
}
