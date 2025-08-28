namespace _05_00_AbstractFactoryPattern;

public class FreeCarViolation : ICarViolation
{
    public void GetResult()
    {
        Console.WriteLine("FreeCarViolation has true result.");
    }
}