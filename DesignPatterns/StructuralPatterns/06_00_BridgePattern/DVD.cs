namespace _06_00_BridgePattern;

public class DVD : ElectronicGoods
{
    /*
    * Implementation specific:
    * Delegating the task
    * to the Implementor object.
    */

    public DVD(IPrice price) : base(price)
    {
        this.type = "DVD";
        this.cost = 1000;
    }
}