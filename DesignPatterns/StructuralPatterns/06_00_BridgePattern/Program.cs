// This is CConsole.WriteLine("***Bridge Pattern Demo.***");

using _06_00_BridgePattern;

Console.WriteLine("Verifying the market price of a television.");
ElectronicGoods eItem = new Television();
eItem.ProductType = "Sony Television";
// Verifying online price
IPrice price = new OnlinePrice();
eItem.Price = price;

eItem.Details();
// Verifying showroom price
price = new ShowroomPrice();
eItem.Price = price;
eItem.Details();