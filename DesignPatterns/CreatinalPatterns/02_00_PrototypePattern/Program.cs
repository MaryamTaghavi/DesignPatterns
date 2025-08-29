/* The Prototype pattern provides an alternative method for instantiating new objects
by copying or cloning an instance of an existing object. */

// Prototype Pattern یعنی ساخت object جدید از روی نمونه موجود بدون اینکه constructor اصلی صدا زده بشه.
// وقتی ساخت شی جدید پر هزینه است و یا پیچیده است از این پترن استفاده میشود.

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


public interface IClonesble
{
    // Creates a new object that is a copy of the current instance ;
    object Clone();
}

// create a shallow copy from an object
// return this.MemberwiseClone() ;

