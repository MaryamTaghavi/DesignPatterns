namespace SMSExample;

public class Provider2 : Provider , ISendSMS
{
    public Provider2(string Name) : base(Name) { }
    public void Send(string message, int phoneNumber)
    {
        Console.WriteLine($"Provider2 send {message} to {phoneNumber}");
    }
}
