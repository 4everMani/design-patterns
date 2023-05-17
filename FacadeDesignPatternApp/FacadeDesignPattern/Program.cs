




using FacadeDesignPattern;

Console.WriteLine("***Facade Pattern Demo.***\n");
// Making a Milano robot with green color.
RobotFacade facade = new RobotFacade("Milano", "green");
facade.ConstructRobot();
// Making a robonaut robot with default steel color.
facade = new RobotFacade("Robonaut");
facade.ConstructRobot();
// Destroying one robot
facade.DestroyRobot();
// Destroying another robot
facade.DestroyRobot();
// This destrcution attempt should fail.
facade.DestroyRobot();
Console.ReadLine();
