/*
دو نوع وجود دارد:

1) object adapter
یک آبجکت (نمونه) از کلاس هدف را در دون خودش نگه میدارد
2) class adapter
از اینترفیس و کلاس هدف ارث بری میکند

*/

// Class Adapter 

// Target interface
public interface ITarget
{
    void Request();
}

// Adaptee (دارای متد متفاوت)
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

// Class Adapter (ارث‌بری)
public class ClassAdapter : Adaptee, ITarget
{
    public void Request()
    {
        // Adaptee را با متد مورد نیاز Target تطبیق می‌دهیم
        SpecificRequest();
    }
}

// Object Adapter

// Target interface
public interface ITarget1
{
    void Request1();
}

// Adaptee
public class Adaptee1
{
    public void SpecificRequest1()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

// Object Adapter (Composition)
public class ObjectAdapter : ITarget1
{
    private readonly Adaptee1 _adaptee;

    public ObjectAdapter(Adaptee1 adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request1()
    {
        // Delegation
        _adaptee.SpecificRequest1();
    }
}
