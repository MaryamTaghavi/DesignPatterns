namespace _01_01_CombineComposite_Visitor;

public interface IEmployee
{
    string Name { get; set; }
    string Dept { get; set; }
    string Designation { get; set; }
    void DisplayDetails();
    double Experience { get; set; }
    void Accept(IVisitor visitor);
}
