namespace _04_00_FacadePattern;

public class RobotFacade
{
    RobotBody robotBody;
    RobotColor robotColor;

    public RobotFacade(string robotType , string color = "steel")
    {
        robotBody = new RobotBody(robotType);
        robotColor = new RobotColor(color);
    }

    public void CostructRobot()
    {
        Console.WriteLine("Robot creation through facade starts ...");
        robotBody.MakeRobotBody();
        robotColor.SetColor();
        Console.WriteLine();
    }

    public void DestroyRobot()
    {
        Console.WriteLine("Making an attempt to destroy one robot using the facade now.");
        robotColor.RemoveColor();
        robotBody.DestroyRobotBody();
        Console.WriteLine();
    }
}
