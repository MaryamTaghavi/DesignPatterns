namespace _04_FactoryMethodPattern;

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal(string animalType);
}
