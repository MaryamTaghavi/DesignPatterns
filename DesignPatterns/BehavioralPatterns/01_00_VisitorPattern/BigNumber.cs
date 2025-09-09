namespace _01_00_VisitorPattern;

// ConcreteElement
public class BigNumber : Number
{
    public BigNumber(string type, int numberValue) : base(type, numberValue)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitBigNumbers(this);
    }
}
