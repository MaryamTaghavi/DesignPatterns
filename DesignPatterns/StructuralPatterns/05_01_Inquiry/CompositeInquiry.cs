namespace _05_01_Inquiry;

public class CompositeInquiry : IInquiry
{
    public string InquiryName { get; set; }

    public InquiryTypeEnum InquiryType { get ; set; }

    private List<IInquiry> subordinateList = new List<IInquiry>();

    public void AddInquiry(IInquiry e)
    {
        subordinateList.Add(e);
    }

    public void RemoveInquiry(IInquiry e)
    {
        subordinateList.Remove(e);
    }
}
