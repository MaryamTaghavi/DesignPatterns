using _05_00_AbstractFactoryPattern;

// Client

Console.WriteLine("***Abstract Factory Pattern Demo.***\n");

// Making a free inquiry through FreeInquiryFactory now.
IInquiryFactory inquiryFactory = FactoryProvider.GetInquiryFactory("free");
ICarViolation carViolation = inquiryFactory.GetCarViolation();
ICarViolationImage carViolationImage = inquiryFactory.GetCarViolationImage();
carViolation.GetResult();
carViolationImage.GetResultImage();
Console.WriteLine("******************");

// Making a monetary inquiry through MonetaryInquiryFactory now.
inquiryFactory = FactoryProvider.GetInquiryFactory("monetary");
carViolation = inquiryFactory.GetCarViolation();
carViolationImage = inquiryFactory.GetCarViolationImage();
carViolation.GetResult();
carViolationImage.GetResultImage();
Console.ReadLine();