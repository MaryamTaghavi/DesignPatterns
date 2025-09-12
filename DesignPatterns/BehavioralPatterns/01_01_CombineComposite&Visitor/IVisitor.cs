namespace _01_01_CombineComposite_Visitor;

public interface IVisitor
{
    // leaf nodes
    void VisitEmployee(Employee  employee);

    // composite nodes
    void VisitEmployee(CompositeEmployee employee);
}
