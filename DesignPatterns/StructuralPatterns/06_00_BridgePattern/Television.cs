namespace _06_00_BridgePattern;

// Refined Abstraction
public class Television : ElectronicGoods
{
    /*
    * Implementation specific:
    * Delegating the task
    * to the Implementor object.
    */
    public override void Details()
    {
        Price.DisplayDetails(ProductType);
    }
}