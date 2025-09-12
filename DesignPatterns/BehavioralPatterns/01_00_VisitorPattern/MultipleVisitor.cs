namespace _01_00_VisitorPattern;

// ConcreteVisitor
public class MultipleVisitor : IVisitor
{
    // با این تغییر رعایت encapsulation میکنیم
    // در واقع متد را overload میکنیم

    // public void VisitBigNumbers(BigNumber number)
    public void VisitNumbers(BigNumber number)
    {
        Number currentNumber = number as Number;

        int temp = currentNumber.NumberValue;

        Console.WriteLine($"{currentNumber.Type} is {currentNumber.NumberValue}; I convert it as:{temp * 4} for rest of my code.");
    }

    // با این تغییر رعایت encapsulation میکنیم
    // در واقع متد را overload میکنیم
    //public void VisitSmallNumbers(SmallNumber number)
    public void VisitNumbers(SmallNumber number)
    {
        Number currentNumber = number as Number;

        int temp = currentNumber.NumberValue;

        Console.WriteLine($"{currentNumber.Type} is {currentNumber.NumberValue}; I use it as:{temp * 2} for rest of my code.");
    }
}