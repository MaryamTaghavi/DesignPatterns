namespace _05_00_AbstractFactoryPattern;

// Concrete Product-B2
public class FreeCarViolation : ICarViolation
{
    public void GetResult()
    {
        Console.WriteLine("FreeCarViolation has true result.");
    }
}