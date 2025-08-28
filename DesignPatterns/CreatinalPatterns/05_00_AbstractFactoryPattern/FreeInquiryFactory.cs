namespace _05_00_AbstractFactoryPattern;

public class FreeInquiryFactory : IInquiryFactory
{
    public ICarViolation GetCarViolation()
    {
        return new FreeCarViolation();
    }

    public ICarViolationImage GetCarViolationImage()
    {
        return new FreeCarViolationImage();
    }
}
