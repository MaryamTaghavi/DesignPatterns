namespace _02_00_DecoratorPattern;

abstract class AbstractHome
{
    public double AdditionalPrice { get; set; }
    public abstract void MakeHome();
}

class ConcreteHome : AbstractHome
{
    public ConcreteHome()
    {
        AdditionalPrice = 0;
    }
    public override void MakeHome()
    {
        Console.WriteLine($"Original House is constructed. Price for this $10000");
    }
}

abstract class AbstractDecorator : AbstractHome
{
    protected AbstractHome home;
    public AbstractDecorator(AbstractHome home)
    {
        this.home = home;
        this.AdditionalPrice = 0;
    }
    public override void MakeHome()
    {
        home.MakeHome();
    }
}

class FloorDecorator : AbstractDecorator
{
    public FloorDecorator(AbstractHome home) : base(home)
    {
        this.AdditionalPrice = 2500;
    }

    public override void MakeHome()
    {
        base.MakeHome();
        AddFloor();
    }
    private void AddFloor()
    {
        Console.WriteLine($"-Additional Floor added. Pay additional ${AdditionalPrice} for it .");
    }
}

class PaintDecorator : AbstractDecorator
{
    public PaintDecorator(AbstractHome home) : base(home)
    {
        this.AdditionalPrice = 5000;
    }

    public override void MakeHome()
    {
        base.MakeHome();
        PaintHome();
    }

    private void PaintHome()
    {
        Console.WriteLine($"-Painting done. Pay additional ${AdditionalPrice} for it .");
    }
}
