namespace _04_01_OrderRequest;

public class Inventory
{
    public bool CheckInventory(string itemId)
    {
        return true;
    }

    public void ReduceInventory(string itemId , int amount)
    {
        Console.WriteLine("Reducing inventory of " + itemId + " by " + amount);
    }
}
