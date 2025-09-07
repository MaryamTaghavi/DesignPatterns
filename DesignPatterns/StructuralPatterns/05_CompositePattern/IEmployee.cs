namespace _05_00_CompositePattern;

public interface IEmployee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Designation { get; set; }
    public void DisplayDetails();
}
