namespace _01_00_VisitorPattern;

public class NumberCollection
{
    List<Number> numberList = new List<Number>();

    public NumberCollection()
    {
        numberList.Add(new SmallNumber("small-1", 10));
        numberList.Add(new SmallNumber("small-2", 20));
        numberList.Add(new SmallNumber("small-3", 30));
        numberList.Add(new BigNumber("big-1", 200));
        numberList.Add(new BigNumber("big-2", 150));
        numberList.Add(new BigNumber("big-3", 70));
    }
    public void AddNumberToList(Number number)
    {
        numberList.Add(number);
    }
    public void RemoveNumberFromList(Number number)
    {
        numberList.Remove(number);
    }
    public void DisplayList()
    {
        Console.WriteLine("Current list is as follows:");
        foreach (Number number in numberList)
        {
            Console.Write(number.NumberValue + "\t");
        }
        Console.WriteLine();
    }
    public void Accept(IVisitor visitor)
    {
        foreach (Number n in numberList)
        {
            n.Accept(visitor);
        }
    }
}
