using _04_00_FacadePattern;

RobotFacade facade = new RobotFacade("Milano","green");
facade.ConstructRobot();

facade = new RobotFacade("Robonaut");
facade.ConstructRobot();

facade.DestroyRobot();

facade.DestroyRobot();

facade.DestroyRobot();

Console.ReadLine();