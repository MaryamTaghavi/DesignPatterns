/*

Element عنصر: اینترفیس یا کلاس پایه که یک متد accept(visitor) داره.

ConcreteElement عنصر واقعی کلاس‌هایی مثل Circle, Rectangle که متد accept رو پیاده‌سازی می‌کنن و Visitor رو می‌پذیرن.

Visitor بازدیدکننده اینترفیس برای عملیات روی انواع مختلف Element.

ConcreteVisitor: عملیات واقعی مثلاً Visitor مخصوص رسم، یا Visitor مخصوص محاسبه مساحت.

*/

using _01_00_VisitorPattern;

Console.WriteLine("***Visitor Pattern Demo***\n");
NumberCollection numberCollection = new NumberCollection();
//Showing the current list
numberCollection.DisplayList();
IncrementNumberVisitor incrVisitor = new
IncrementNumberVisitor();
//Visitor is visiting the list
Console.WriteLine("IncrementNumberVisitor is about to visit the list: ");
numberCollection.Accept(incrVisitor);
//Showing the current list
numberCollection.DisplayList();
Console.ReadLine();