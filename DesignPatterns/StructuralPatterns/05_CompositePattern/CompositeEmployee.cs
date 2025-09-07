namespace _05_00_CompositePattern;

// Non-leaf node
public class CompositeEmployee : IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }

    private List<IEmployee> subordinateList = new List<IEmployee>();

    // To add an employee
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
        Console.WriteLine($"\n{Name} works in {Dept} department. Designation:{Designation}");

        foreach (IEmployee e in subordinateList)
        {
            e.DisplayDetails();
        }
    }
}
