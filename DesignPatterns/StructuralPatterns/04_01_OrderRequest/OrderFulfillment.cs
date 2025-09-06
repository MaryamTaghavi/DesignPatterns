namespace _04_01_OrderRequest;

public class OrderFulfillment
{
    private Inventory _inventory;

    public OrderFulfillment(Inventory inventory)
    {
        _inventory = inventory;
    }

    public void Fulfill(string name , string address , string[] items)
    {
        Console.WriteLine("Inserting order into database");

        foreach(var item in items)
        {
            _inventory.ReduceInventory(item , 1);
        }
    }
}
