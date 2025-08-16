namespace _02_PrototypePattern;

public class CarFactory
{
    private BasicCar nano, ford;
    public CarFactory()
    {
        nano = new Nano("Green Nano");
        ford = new Ford("Ford Yellow");
    }
    public BasicCar GetNano()
    {
        if (nano != null)
        {
            // Nano was created earlier.
            // Returning a clone of it.
            return nano.Clone();
        }
        else
        {
            /*
            Create a nano for the first
            time and return it.
            */
            nano = new Nano("Green Nano");
            return nano;
        }
    }

    public BasicCar GetFord()
    {
        if (ford != null)
        {
            // Ford was created earlier.
            // Returning a clone of it.
            return ford.Clone();
        }
        else
        {
            /*
            Create a nano for the first
            time and return it.
            */
            ford = new Ford("Ford Yellow");
            return ford;
        }
    }
}
