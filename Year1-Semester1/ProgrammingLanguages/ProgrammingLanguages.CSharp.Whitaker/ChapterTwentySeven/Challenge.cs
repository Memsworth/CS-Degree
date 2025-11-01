namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentySeven;

public static class Challenge
{
    public static void RoboticInterface()
    {
        var robot = new Robot2();
        for (int i = 0; i < robot.Commands.Length; i++)
        {
            var input = Console.ReadLine();
            IRobotCommand? command = null;
            switch (input)
            {
                case "on":
                    command = new OnCommand2();
                    robot.Commands[i] = command;
                    break;
                case "off":
                    command = new OffCommand2();
                    robot.Commands[i] = command;
                    break;
                case "north":
                    command = new NorthCommand2();
                    robot.Commands[i] = command;
                    break;
                case "south":
                    command = new SouthCommand2();
                    robot.Commands[i] = command;
                    break;
                case "east":
                    command = new EastCommand2();
                    robot.Commands[i] = command;
                    break;
                case "west":
                    command = new WestCommand2();
                    robot.Commands[i] = command;
                    break;
                default:
                    break;
            }
        }
        robot.Run();
    }
}


public class Robot2
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (var command in Commands)
        {
            if (command is null)
                Console.WriteLine("Error in command");
            else
                command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
    public void Run(Robot2 robot);
}


public class OnCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        if (robot.IsPowered)
            robot.Y += 1;
    }
}
public class SouthCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        if (robot.IsPowered)
            robot.Y -= 1;
    }
}
public class WestCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        if (robot.IsPowered)
            robot.X -= 1;
    }
}
public class EastCommand2 : IRobotCommand
{
    public void Run(Robot2 robot)
    {
        if (robot.IsPowered)
            robot.X += 1;
    }
}