namespace _03_01_ChainigMethod;

class Car : IBuilder
{
    private string brandName;
    private Product product;
    public Car(string brand)
    {
        product = new Product();
        this.brandName = brand;
    }
    public IBuilder StartUpOperations(string optionalStartUpMessage = " Making a car for you.")
    { // Starting with brandname
        product.Add(optionalStartUpMessage);
        product.Add($"Car model name :{this.brandName}");
        return this;
    }
    public IBuilder BuildBody(string optionalBodyType = "Steel")
    {
        product.Add(optionalBodyType);
        return this;
    }
    public IBuilder InsertWheels(int optionalNoOfWheels = 4)
    {
        product.Add($"{optionalNoOfWheels} wheels are added");
        return this;
    }
    public IBuilder AddHeadlights(int optionalNoOfHeadLights = 2)
    {
        product.Add($"{optionalNoOfHeadLights} Headlights are added");
        return this;
    }
    public IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.")
    {
        product.Add(optionalEndMessage);
        return this;
    }
    public Product ConstructCar()
    {
        return product;
    }
}