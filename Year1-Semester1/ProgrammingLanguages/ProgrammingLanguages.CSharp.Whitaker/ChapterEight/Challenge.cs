namespace ProgrammingLanguages.CSharp.Whitaker.ChapterEight;

public static class Challenge
{
    public static void TheDefenseOfConsolas()
    {
        Console.Title = "Defense of Consolas";


        Console.Write("Target Row? ");
        int.TryParse(Console.ReadLine(), out int Row);

        Console.Write("Target Column? ");
        int.TryParse(Console.ReadLine(), out int Column);


        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Deploy to: ");

        Console.WriteLine($"({Row}, {Column - 1})");
        Console.WriteLine($"({Row - 1}, {Column})");
        Console.WriteLine($"({Row}, {Column + 1})");
        Console.WriteLine($"({Row + 1}, {Column})");

        Console.ResetColor();
        Console.Beep();

    }
}
