using _24_00_SimpleFactoryPattern;

Console.WriteLine("*** Simple Factory Pattern Demo.***\n");
IAnimal preferredType = null;
SimpleFactory simpleFactory = new SimpleFactory();
#region The code region that can vary based on users preference
/*
* Since this part may vary,we're moving the
* part to CreateAnimal() in SimpleFactory class.
*/
preferredType = simpleFactory.CreateAnimal();
#endregion
#region The codes that do not change frequently.
preferredType.AboutMe();
#endregion
Console.ReadKey();