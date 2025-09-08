namespace SMSExample;

public class Provider1 : Providers , ISendSMS
{
    Provider1(string Name) : base(Name) { }
    public void Send(string message)
    {
        Console.WriteLine(message);
    }
}
