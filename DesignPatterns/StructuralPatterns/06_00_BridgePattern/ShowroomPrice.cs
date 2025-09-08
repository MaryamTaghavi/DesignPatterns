namespace _06_00_BridgePattern;

// This is ConcreteImplementor-2
// ShowroomPrice class

public class ShowroomPrice : IPrice
{
    public void DisplayDetails(string product, double price)
    {
        Console.Write($"\n{product} price at showroom is : {price}$");
    }

    public void GetDiscount(int percentage)
    {
        Console.Write($"\nAt showroom, you can get upto {percentage}% discount.");
    }
}