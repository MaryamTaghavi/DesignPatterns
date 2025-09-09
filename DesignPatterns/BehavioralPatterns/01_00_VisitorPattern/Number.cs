namespace _01_00_VisitorPattern;

// Element
public abstract class Number
{
    private int numberValue;
    private string type;

    public Number(string type , int numberValue)
    {
        this.type = type;
        this.numberValue = numberValue;
    }

    public int NumberValue { get { return numberValue; } }
    public string Type { get { return type; } }
    public abstract void Accept(IVisitor  visitor);
}
