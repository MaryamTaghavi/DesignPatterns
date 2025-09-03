
OldPrinter oldPrinter = new OldPrinter();
oldPrinter.Print("old");

INewPrinter newPrinter = new PrinterAdapter(oldPrinter);
newPrinter.Print("new");

public class OldPrinter
{
    public void Print(string printerName)
    {
        Console.WriteLine("Please use {0}" , printerName);
    }
}

public interface INewPrinter
{
    void Print(string printerName);
}

public class PrinterAdapter : INewPrinter
{
    OldPrinter _oldPrinter;
    public PrinterAdapter(OldPrinter oldPrinter)
    {
        _oldPrinter = oldPrinter;
    }

    public void Print(string printerName)
    {
        _oldPrinter.Print(printerName);
    }
}