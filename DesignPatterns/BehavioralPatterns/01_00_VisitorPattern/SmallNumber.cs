namespace _01_00_VisitorPattern;

// ConcreteElement
public class SmallNumber : Number
{
    public SmallNumber(int numberValue, string type) : base(numberValue, type)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitSmallNumbers(this);
    }
}
