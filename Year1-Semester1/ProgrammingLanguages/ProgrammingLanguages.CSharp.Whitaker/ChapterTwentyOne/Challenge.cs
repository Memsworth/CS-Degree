using ProgrammingLanguages.CSharp.Whitaker.ChapterEighteen;

namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentyOne;

public class Challenge
{
    public static void ArrowFactories()
    {
        Console.WriteLine("pick an option:");
        Console.WriteLine("1-  Elite Arrow");
        Console.WriteLine("2- Beginner Arrow");
        Console.WriteLine("3- Marksman Arrow");
        Console.WriteLine("4- Custom Arrow");

        Arrow arrow = null;

        var userChoice = int.Parse(Console.ReadLine());

        switch(userChoice)
        {
            case 1:
                arrow = Arrow.CreateEliteArrow();
                break;
            case 2:
                arrow = Arrow.CreateBeginnerArrow();
                break;
            case 3:
                arrow = Arrow.CreateMarksmanArrow();
                break;
            case 4:
                ChapterEighteen.Challenge.VinFletcherArrows();
                break;
        }

        if (arrow is not null)
            Console.WriteLine($"Cost of arrow is {arrow.GetCost()}");
    }
}