namespace _04_FactoryMethodPattern;

public class TigerFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}
