namespace SMSExample;

public class Provider2 : Providers , ISendSMS
{
    Provider2(string Name) : base(Name) { }
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}
