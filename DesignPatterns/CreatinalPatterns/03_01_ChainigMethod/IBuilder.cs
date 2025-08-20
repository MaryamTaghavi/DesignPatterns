namespace _03_01_ChainigMethod;

interface IBuilder
{
    IBuilder StartUpOperations(string optionalStartUpMessage =" Making a car for you.");
    IBuilder BuildBody(string optionalBodyType = "This is a body of a Car");
    IBuilder InsertWheels(int optionalNoOfWheels = 4);
    IBuilder AddHeadlights(int optionalNoOfHeadLights = 2);
    IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.");
    Product ConstructCar();
}
