using _04_01_OrderRequest;

var orderReq = new OrderRequest();

// -- Without Facade Pattern --

//var auth = new Authenticate();

//var inventory = new Inventory();

//foreach(var id in orderReq.ItemIds)
//{
//    inventory.CheckInventory(id);
//}

//var payment = new Payment(orderReq.Name , orderReq.CardNumber , orderReq.Amount);
//payment.Pay();

//var orderFulfillment = new OrderFulfillment(inventory);
//orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);

// -- With Facade Pattern --

OrderServiceFacade orderService = new OrderServiceFacade();
orderService.Order(orderReq);