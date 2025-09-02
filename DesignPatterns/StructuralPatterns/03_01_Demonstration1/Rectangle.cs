namespace _03_01_Demonstration1;

class Rectangle : IRectangle
{
    double length;
    public double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public double CalculateArea()
    {
        return length * width;
    }
    public void AboutMe()
    {
        Console.WriteLine("Actually, I am a Rectangle");
    }
}