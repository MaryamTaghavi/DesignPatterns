namespace _06_01_RemoteControl;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base (device)
    {

    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Setting channel to " + channel);
    }
}
