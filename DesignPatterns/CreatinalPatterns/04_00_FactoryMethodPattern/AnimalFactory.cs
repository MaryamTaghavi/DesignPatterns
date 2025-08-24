namespace _04_FactoryMethodPattern;

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal();

    public IAnimal MakeAnimal()
    {
        Console.WriteLine("You cannot ignore parent rules.");
        IAnimal animal = CreateAnimal();
        animal.AboutMe();
        return animal;
    }
}
