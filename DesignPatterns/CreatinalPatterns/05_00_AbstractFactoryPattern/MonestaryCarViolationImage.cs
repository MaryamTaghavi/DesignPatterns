namespace _05_00_AbstractFactoryPattern;

public class MonestaryCarViolationImage : ICarViolationImage
{
    public void GetResult()
    {
        Console.WriteLine("MonestaryCarViolationImage has true result.");
    }
}