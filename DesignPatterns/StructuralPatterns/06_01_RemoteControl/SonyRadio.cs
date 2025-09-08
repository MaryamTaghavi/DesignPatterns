namespace _06_01_RemoteControl;

public class SonyRadio : IDevice
{
    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting Sony radio channel to" + channel);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning Sony radio off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning Sony radio on");
    }
}
