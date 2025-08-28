namespace _05_00_AbstractFactoryPattern;

public interface IInquiryFactory
{
    ICarViolation GetCarViolation();
    ICarViolationImage GetCarViolationImage();
}
