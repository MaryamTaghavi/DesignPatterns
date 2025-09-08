// This is CConsole.WriteLine("***Bridge Pattern Demo.***");

using _06_00_BridgePattern;

Console.WriteLine("Verifying the market price of a television.");

#region Television

ElectronicGoods eItem = new Television(new OnlinePrice());
eItem.Details();
eItem.Discount(5);

eItem = new Television(new ShowroomPrice());
eItem.Details();
eItem.Discount(10);

#endregion

#region DVD

eItem = new DVD(new OnlinePrice());
eItem.Details();
eItem.Discount(7);

eItem = new DVD(new ShowroomPrice());
eItem.Details();
eItem.Discount(9);

#endregion

Console.ReadLine();