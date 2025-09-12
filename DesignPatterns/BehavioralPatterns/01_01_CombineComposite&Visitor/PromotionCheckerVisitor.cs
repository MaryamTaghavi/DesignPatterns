namespace _01_01_CombineComposite_Visitor;

// Concrete visitor class
public class PromotionCheckerVisitor : IVisitor
{
    public void VisitEmployee(CompositeEmployee employee)
    {
        throw new NotImplementedException();
    }

    public void VisitEmployees(Employee employee)
    {
        throw new NotImplementedException();
    }
}
