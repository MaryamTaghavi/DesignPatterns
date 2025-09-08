namespace _06_01_RemoteControl;

public class LGRadio : IDevice
{
    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting LG radio channel to" + channel);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning LG radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning LG radio on");
    }
}