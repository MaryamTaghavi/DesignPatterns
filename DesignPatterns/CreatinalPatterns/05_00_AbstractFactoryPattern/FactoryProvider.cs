namespace _05_00_AbstractFactoryPattern;

public class FactoryProvider
{
    public static IInquiryFactory GetInquiryFactory(string factoryType)
    {
        if (factoryType.Contains("free"))
        {
            return new FreeInquiryFactory();
        }
        else if (factoryType.Contains("monetary"))
        {
            return new MonetaryInquiryFactory();
        }
        else
        {
            throw new ArgumentException("Please get a type");
        }
    }
}
