namespace _04_01_OrderRequest;

public class OrderServiceFacade
{
    public void Order (OrderRequest request)
    {
        var orderReq = new OrderRequest();

        var auth = new Authenticate();

        var inventory = new Inventory();

        foreach (var id in orderReq.ItemIds)
        {
            inventory.CheckInventory(id);
        }

        var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
        payment.Pay();

        var orderFulfillment = new OrderFulfillment(inventory);
        orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
    }
}
