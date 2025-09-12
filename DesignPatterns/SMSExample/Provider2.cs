namespace SMSExample;

public class Provider2 : Provider , ISendSMS
{
    Provider2(string Name) : base(Name) { }
    public void Send(string message)
    {
        Console.WriteLine($"Provider2 send {message}");
    }
}
