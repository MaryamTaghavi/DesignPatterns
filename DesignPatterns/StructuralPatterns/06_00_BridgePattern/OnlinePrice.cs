namespace _06_00_BridgePattern;

// This is ConcreteImplementor-1
// OnlinePrice class

public class OnlinePrice : IPrice
{
    public void DisplayDetails(string productType)
    {
        Console.Write($"\n{productType} price at online is : 2000$");
    }
}