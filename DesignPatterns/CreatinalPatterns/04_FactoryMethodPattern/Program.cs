/* این پترن به subclass ها اجازه میدهد که شی را انتخاب و ایجاد کنند
 فرض کنید کارخانه تولید animal داریم
یک شی به نام CatFactory و دیگری به نام TiggerFactory است.
 */

using _04_FactoryMethodPattern;

Console.WriteLine("***Factory Pattern Demo.***\n");
// Creating a Tiger Factory
AnimalFactory tigerFactory = new TigerFactory();
// Creating a tiger using the Factory Method
IAnimal tiger = tigerFactory.CreateAnimal();
tiger.AboutMe();
// Creating a DogFactory
AnimalFactory dogFactory = new DogFactory();
// Creating a dog using the Factory Method
IAnimal dog = dogFactory.CreateAnimal();
dog.AboutMe();
Console.ReadKey();