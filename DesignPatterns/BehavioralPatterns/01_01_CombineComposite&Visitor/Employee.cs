namespace _01_01_CombineComposite_Visitor;

// Leaf node
public class Employee : IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }
    public double Experience { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitEmployee(this);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{Name} works in {Dept} department. Designation {Designation}. Experience : {Experience} years." );
    }
}
