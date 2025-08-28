namespace _05_00_AbstractFactoryPattern;

// Abstract Factory
public interface IInquiryFactory
{
    ICarViolation GetCarViolation();
    ICarViolationImage GetCarViolationImage();
}
