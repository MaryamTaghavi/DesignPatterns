namespace _05_00_AbstractFactoryPattern;

// Concrete Factory 1-Monetary Inquiry Factory
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
