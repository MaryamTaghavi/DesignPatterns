namespace _05_00_CompositePattern;

// Leaf Node
public class Employee : IEmployee
{
    public string Name { get ; set ; }
    public string Dept { get ; set ; }
    public string Designation { get ; set ; }

    public void DisplayDetails()
    {
        Console.WriteLine($"\t{Name} works in {Dept} department. Designation: {Designation}");
    }
}
