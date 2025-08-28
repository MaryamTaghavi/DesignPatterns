namespace _05_00_AbstractFactoryPattern;


// Concrete Product-A1
public class MonestaryCarViolationImage : ICarViolationImage
{
    public void GetResultImage()
    {
        Console.WriteLine("MonestaryCarViolationImage has true result.");
    }
}