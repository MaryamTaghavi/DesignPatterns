namespace _03_01_Demonstration1;

public class RectangleAdapter : IRectangle
{
    ITriangle triangle;
    public RectangleAdapter(ITriangle triangle)
    {
        this.triangle = triangle;
    }
    public void AboutMe()
    {
        triangle.AboutTriangle();
    }
    public double CalculateArea()
    {
        return triangle.CalculateAreaOfTriangle();
    }
}
