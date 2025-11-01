namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentySix;

public static class Challenge
{
    public static void OldRobot()
    {
        var robot = new Robot();

        for (int i = 0; i < robot.Commands.Length; i++)
        {
            var input = Console.ReadLine();
            RobotCommand? command = null;
            switch (input)
            {
                case "on":
                    command = new OnCommand();
                    robot.Commands[i] = command;
                    break;
                case "off":
                    command = new OffCommand();
                    robot.Commands[i] = command;
                    break;
                case "north":
                    command = new NorthCommand();
                    robot.Commands[i] = command;
                    break;
                case "south":
                    command = new SouthCommand();
                    robot.Commands[i] = command;
                    break;
                case "east":
                    command = new EastCommand();
                    robot.Commands[i] = command;
                    break;
                case "west":
                    command = new WestCommand();
                    robot.Commands[i] = command;
                    break;
                default:
                    break;
            }
        }

        robot.Run();
    }
}


#region OldRobot
public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            if (command is null)
                Console.WriteLine("Error in command");
            else
                command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y += 1;
    }
}
public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.Y -= 1;
    }
}
public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X -= 1;
    }
}
public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
            robot.X += 1;
    }
}
#endregion