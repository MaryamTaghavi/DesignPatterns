namespace _05_00_AbstractFactoryPattern;

// Concrete Factory 1-Free Inquiry Factory
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
