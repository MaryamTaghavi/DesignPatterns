namespace _05_00_AbstractFactoryPattern;

public class MonetaryCarViolation : ICarViolation
{
    public void GetResult()
    {
        Console.WriteLine("MonetaryCarViolation has true result.");
    }
}
