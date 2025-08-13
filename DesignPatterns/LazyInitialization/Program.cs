
public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance =
        new Lazy<Singleton>(() => new Singleton());

    private Singleton()
    {
        Console.WriteLine("Singleton instance created!");
    }

    public static Singleton Instance => _instance.Value;
}