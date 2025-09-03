
OldLamp oldLamp = new OldLamp();
oldLamp.TurnOn("old");

INewLamp newLamp = new LampAdapter();
newLamp.TurnOnNewLamp("new");

Console.ReadLine();

public class OldLamp
{
    public void TurnOn(string lamp)
    {
        Console.WriteLine("TurnOn {0}" , lamp);
    }
}

public interface INewLamp
{
    void TurnOnNewLamp(string lamp);
}

public class LampAdapter : OldLamp, INewLamp
{
    public void TurnOnNewLamp(string newLamp)
    {
        TurnOn(newLamp);
    }
}