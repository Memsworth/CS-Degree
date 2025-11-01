namespace ProgrammingLanguages.CSharp.Whitaker.ChapterFour;

public static class Challenge
{
    public static void TheThingNamer()
    {
        //
        Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine();

        //
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine();
        string c = "of Doom";
        string d = "3000";
        Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
    }
}
