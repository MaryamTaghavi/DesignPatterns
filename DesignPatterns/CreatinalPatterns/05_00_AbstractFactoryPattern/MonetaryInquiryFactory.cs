namespace _05_00_AbstractFactoryPattern;

public class MonetaryInquiryFactory : IInquiryFactory
{
    public ICarViolation GetCarViolation()
    {
        return new MonetaryCarViolation();
    }

    public ICarViolationImage GetCarViolationImage()
    {
        return new MonestaryCarViolationImage();
    }
}
