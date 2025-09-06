using _04_01_OrderRequest;

/*
یک اپلیکیشن داشتی که چندین سرویس مختلف داری :

Logging

Caching

Security

می‌خوای یه رابط ساده بسازی که کاربر فقط با یک متد بتونه همه سرویس‌ها رو استفاده کنه، بدون اینکه بدونه هر سرویس چطوری کار می‌کنه.
 */


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