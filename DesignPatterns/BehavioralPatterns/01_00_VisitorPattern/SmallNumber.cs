namespace _01_00_VisitorPattern;

// ConcreteElement
public class SmallNumber : Number
{
    public SmallNumber(string type , int numberValue) : base(type ,numberValue)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitSmallNumbers(this);
    }
}
