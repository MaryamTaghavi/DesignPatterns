namespace _06_00_BridgePattern;

// This is ConcreteImplementor-2
// ShowroomPrice class

public class ShowroomPrice : IPrice
{
    public void DisplayDetails(string productType)
    {
        Console.Write($"\n{productType} price at showroom is : 3000$");
    }

    public void GetDiscount(int percentage)
    {
        Console.Write($"\nAt showroom, you can get upto {percentage}% discount.");
    }
}