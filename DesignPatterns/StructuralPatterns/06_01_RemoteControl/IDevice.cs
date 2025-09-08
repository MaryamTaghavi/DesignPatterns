namespace _06_01_RemoteControl;

// Bridge
public interface IDevice
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
}
