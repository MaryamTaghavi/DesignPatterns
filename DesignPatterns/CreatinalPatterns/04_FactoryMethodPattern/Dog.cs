namespace _04_FactoryMethodPattern;

public class Dog : IAnimal
{
    public void AboutMe()
    {
        Console.WriteLine("The dog says: bow-Wow. I prefer barking.");
    }
}
