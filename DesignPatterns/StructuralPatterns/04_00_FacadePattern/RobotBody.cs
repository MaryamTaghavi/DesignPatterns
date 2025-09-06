namespace _04_00_FacadePattern;

public class RobotBody
{
    string robotType;
    static int count = 0;

    public RobotBody(string robotType)
    {
        this.robotType = robotType ;
    }

    public void MakeRobotBody()
    {
        Console.WriteLine($"Constructing one {robotType} robot.");
        Console.WriteLine($"Robot creatin finished.");
        Console.WriteLine($"Total number of robot created at this moment={++count}");
    }

    public void DestroyRobotBody()
    {
        if (count > 0)
        {
            --count;
            Console.WriteLine("Robot's destruction process is over.");
        }
        else
        {
            Console.WriteLine("All robots are destroyed.");
            Console.WriteLine("Color removal operation will not continue.");
        }
    }
}
