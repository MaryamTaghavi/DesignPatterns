namespace _01_00_VisitorPattern;

// اینترفیس بازدیدکننده Element

public interface IVisitor
{
    // با این تغییر رعایت encapsulation میکنیم
    // در واقع متد را overload میکنیم

    void VisitNumbers(SmallNumber number);
    void VisitNumbers(BigNumber number);

    //void VisitSmallNumbers(SmallNumber number);
    //void VisitBigNumbers(BigNumber number);
}
