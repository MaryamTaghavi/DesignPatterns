namespace _01_01_CombineComposite_Visitor;

// Concrete visitor class
public class PromotionCheckerVisitor : IVisitor
{
    string eligibleForPromotion = String.Empty;

    public void VisitEmployee(CompositeEmployee employee)
    {
        /*
         We'll promote them if experience is greater than 15 years.
        */
        eligibleForPromotion = employee.Experience > 15 ? "Yes" : "No";
        Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion ? :{ eligibleForPromotion}");
    }

    public void VisitEmployee(Employee employee)
    {
        /*
         We'll promote them if experience is greater than 12 years.
        */
        eligibleForPromotion = employee.Experience > 12 ? "Yes" : "No";
        Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion ? :{ eligibleForPromotion}");
    }
}
