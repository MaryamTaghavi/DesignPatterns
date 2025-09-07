using _05_01_Inquiry;

#region Free Inquiry

Inquiry freeInquiry = new Inquiry
{
    InquiryType = InquiryTypeEnum.Free ,
    InquiryName = "عکس خلافی"

};

CompositeInquiry composite = new CompositeInquiry
{
    InquiryType = InquiryTypeEnum.Free,
    InquiryName = "خلافی رایگان"

};

composite.AddInquiry(freeInquiry);

#endregion

#region DisFree Inquiry

Inquiry disFreeInquiry = new Inquiry
{
    InquiryType = InquiryTypeEnum.DisFree,
    InquiryName = "استعلام خلافی"

};

CompositeInquiry composite1 = new CompositeInquiry
{
    InquiryType = InquiryTypeEnum.DisFree,
    InquiryName = "خلافی پولی"

};

composite1.AddInquiry(disFreeInquiry);

#endregion