namespace SMSExample;

public abstract class Provider
{
    public string Name { get; set; }

    public Provider(string Name)
    {
        this.Name = Name;
    }
}
