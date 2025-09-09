namespace _01_00_VisitorPattern;

// اینترفیس بازدیدکننده Element

public interface IVisitor
{
    void VisitSmallNumbers(SmallNumber number);
    void VisitBigNumbers(BigNumber number);
}
