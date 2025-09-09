namespace _01_00_VisitorPattern;

// ConcreteVisitor
public class MultipleVisitor : IVisitor
{
    public void VisitBigNumbers(BigNumber number)
    {
        Number currentNumber = number as Number;

        int temp = currentNumber.NumberValue;

        Console.WriteLine($"{currentNumber.Type} is {currentNumber.NumberValue}; I convert it as:{temp * 4} for rest of my code.");
    }

    public void VisitSmallNumbers(SmallNumber number)
    {
        Number currentNumber = number as Number;

        int temp = currentNumber.NumberValue;

        Console.WriteLine($"{currentNumber.Type} is {currentNumber.NumberValue}; I use it as:{temp * 2} for rest of my code.");
    }
}