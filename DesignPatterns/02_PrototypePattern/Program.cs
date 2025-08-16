/* The Prototype pattern provides an alternative method for instantiating new objects
by copying or cloning an instance of an existing object. */

using _02_PrototypePattern;

Console.WriteLine("***Prototype Pattern Demo***\n");
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
Console.ReadLine();

public interface IClonesble
{
    // Creates a new object that is a copy of the current instance ;
    object Clone();
}

// create a shallow copy from an object
// return this.MemberwiseClone() ;

