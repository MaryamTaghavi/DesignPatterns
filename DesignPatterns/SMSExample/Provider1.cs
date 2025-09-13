namespace SMSExample;

public class Provider1 : Provider , ISendSMS
{
    public Provider1(string Name) : base(Name) { }
    public void Send(string message , int phoneNumber)
    {
        Console.WriteLine($"Provider1 send {message} to {phoneNumber}");
    }
}
