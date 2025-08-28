namespace _05_00_AbstractFactoryPattern;

// Concrete Product-A2
public class FreeCarViolationImage : ICarViolationImage
{
    public void GetResultImage()
    {
        Console.WriteLine("FreeCarViolationImage has true result.");
    }
}
