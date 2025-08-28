namespace _05_00_AbstractFactoryPattern;

// Concrete Product-B1
public class MonetaryCarViolation : ICarViolation
{
    public void GetResult()
    {
        Console.WriteLine("MonetaryCarViolation has true result.");
    }
}
