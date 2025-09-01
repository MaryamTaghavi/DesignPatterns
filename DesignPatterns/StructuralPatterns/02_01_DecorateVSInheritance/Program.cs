// inheritance
// در این مدل به ازای هر ترکیب اضافه باید یک کلاس جداگانه ایجاد کنیم

ICoffee coffee = new SimpleCoffee();
    coffee = new MilkDecorator(coffee);
    coffee = new SugarDecorator(coffee);

Console.WriteLine(coffee.GetCost());

class Coffee
{
    public virtual string GetCost() => "5$";
}

class MilkCoffee : Coffee
{
    public override string GetCost() => base.GetCost() + " + Milk(1$)";
}

class SugarMilkCoffee : MilkCoffee
{
    public override string GetCost() => base.GetCost() + " + Sugar(0.5$)";
}

// decorator
// ولی این پترن سبب ایجاد فیچرهای داینامیک بدون نیاز به کلاس اضافه میشود
// نیازی به ساختن کلاس MilkSugar نیست
// با ترکیب milkDecorator و sugarDecorator میتوان milkSugar ایجاد کرد

interface ICoffee { string GetCost(); }

class SimpleCoffee : ICoffee
{
    public string GetCost() => "5$";
}

// در واقع وجود private ICoffee coffee
// باعث رفرنس به آبجکت اصلی است
// و این اصل پترن دیکوریتور است
class MilkDecorator : ICoffee
{
    private ICoffee coffee;
    public MilkDecorator(ICoffee coffee) { this.coffee = coffee; }
    public string GetCost() => coffee.GetCost() + " + Milk(1$)";
}

class SugarDecorator : ICoffee
{
    private ICoffee coffee;
    public SugarDecorator(ICoffee coffee) { this.coffee = coffee; }
    public string GetCost() => coffee.GetCost() + " + Sugar(0.5$)";
}