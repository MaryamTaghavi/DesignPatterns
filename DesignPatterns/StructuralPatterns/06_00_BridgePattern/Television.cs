namespace _06_00_BridgePattern;

// Refined Abstraction
public class Television : ElectronicGoods
{
    /*
    * Implementation specific:
    * Delegating the task
    * to the Implementor object.
    */

    public Television(IPrice price) : base(price)
    {
        this.type = "Television";
        this.cost = 2000;
    }
}