namespace _05_00_AbstractFactoryPattern;

public class FreeCarViolationImage : ICarViolationImage
{
    public void GetResult()
    {
        Console.WriteLine("FreeCarViolationImage has true result.");
    }
}
