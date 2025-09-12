namespace _01_00_VisitorPattern;

// ConcreteElement
public class SmallNumber : Number
{
    public SmallNumber(string type , int numberValue) : base(type ,numberValue)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        // با این تغییر رعایت encapsulation میکنیم
        // در واقع متد را overload میکنیم
        // visitor.VisitSmallNumbers(this);

        visitor.VisitNumbers(this);
    }
}
