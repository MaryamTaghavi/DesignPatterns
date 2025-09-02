namespace _03_01_Demonstration1;

class Triangle : ITriangle
{
    double baseLength; // base
    double height; // height
    public Triangle(double length, double height)
    {
        this.baseLength = length;
        this.height = height;
    }
    public double CalculateAreaOfTriangle()
    {
        return 0.5 * baseLength * height;
    }
    public void AboutTriangle()
    {
        Console.WriteLine("Actually, I am a Triangle.");
    }
}
