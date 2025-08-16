/* The Prototype pattern provides an alternative method for instantiating new objects
by copying or cloning an instance of an existing object. */

// Prototype Pattern یعنی ساخت object جدید از روی نمونه موجود بدون اینکه constructor اصلی صدا زده بشه.

using _02_PrototypePattern;

// مثال 1
Console.WriteLine("***Prototype Pattern Demo With Shallow copy***\n");
CarFactory carFactory = new CarFactory();
// Get a Nano
BasicCar basicCar = carFactory.GetNano();
//Working on cloned copy
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
SetAdditionalPrice();
Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");
// Get a Ford now
basicCar = carFactory.GetFord();
// Working on cloned copy
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.
SetAdditionalPrice();
Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");


// مثال 2
Console.WriteLine("***Prototype Pattern Demo With Deep copy***\n");
Person person = new Person();
person.UserName = "m.taghavi";
person.FirstName = "Maryam";
person.LastName = "Taghavi";

var newObject = person.DeepCopy();
var newPerson = newObject.Item2;
var newPerson2 = newObject.Item1;

Console.WriteLine($"UserName is: {newPerson.UserName}, FirstName is: {newPerson.FirstName}, LastName is: {newPerson.LastName}");

newPerson2.UserName = "p.ramezanpoor";
newPerson2.FirstName = "Parsa";
newPerson2.LastName = "Ramezanpoor";
Console.WriteLine($"UserName is: {newPerson2.UserName}, FirstName is: {newPerson2.FirstName}, LastName is: {newPerson2.LastName}");

Console.ReadLine();

public interface IClonesble
{
    // Creates a new object that is a copy of the current instance ;
    object Clone();
}

// create a shallow copy from an object
// return this.MemberwiseClone() ;

