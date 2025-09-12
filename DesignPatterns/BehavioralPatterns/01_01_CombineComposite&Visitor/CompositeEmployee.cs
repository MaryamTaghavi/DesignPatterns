namespace _01_01_CombineComposite_Visitor;

// Non-leaf node
public class CompositeEmployee : IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }
    public double Experience { get; set; }

    public List<IEmployee> subordinateList = new List<IEmployee>();

    public void AddEmployee(IEmployee e)
    {
        subordinateList.Add(e);
    }

    // To remove an employee
    public void RemoveEmployee(IEmployee e)
    {
        subordinateList.Remove(e);
    }

    // Details of a composite node
    public void DisplayDetails()
    {
        Console.WriteLine($"\n{Name} works in {Dept} department. Designation:{Designation}. Experience {Experience} years.");

        foreach (IEmployee e in subordinateList)
        {
            e.DisplayDetails();
        }
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitEmployee(this);
    }
}
