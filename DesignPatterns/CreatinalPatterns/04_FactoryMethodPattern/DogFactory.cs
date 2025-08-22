namespace _04_FactoryMethodPattern;

public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}
