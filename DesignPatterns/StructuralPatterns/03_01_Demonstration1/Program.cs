using _03_01_Demonstration1;

Console.WriteLine("***Adapter Pattern Demo***\n");
IRectangle rectangle = new Rectangle(20, 10);
Console.WriteLine("For initial verification purposes, printing the areas of both shapes.");
Console.WriteLine("Rectangle area is:{0} Square unit",
rectangle.CalculateArea());
ITriangle triangle = new Triangle(20, 10);
Console.WriteLine("Triangle area is:{0} Square unit", triangle.
CalculateAreaOfTriangle());
Console.WriteLine("\nNow using the adapter.");
IRectangle adapter = new RectangleAdapter(triangle);
Console.Write("True fact : ");
adapter.AboutMe();
Console.WriteLine($" and my area is : {adapter.CalculateArea()} square unit.");
// Alternative way:
Console.WriteLine("\nUsing the adapter in a different way now.");
// Passing a Triangle instead of a Rectangle
Console.WriteLine($"Area of the triangle using the adapter is :{GetDetails(adapter)} square unit.");
Console.ReadKey();

/*
* The following method does not know
* that through the adapter, it can
* actually process a
* Triangle instead of a Rectangle.
*/
static double GetDetails(IRectangle rectangle)
{
    rectangle.AboutMe();
    return rectangle.CalculateArea();
}