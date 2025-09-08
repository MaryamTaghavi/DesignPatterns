namespace _06_00_BridgePattern;

// Implementor
public interface IPrice
{
    void DisplayDetails(string product);
    void GetDiscount(int percentage);
}
