namespace SMSExample;

public abstract class Providers
{
    public string Name { get; set; }

    public Providers(string Name)
    {
        this.Name = Name;
    }
}
