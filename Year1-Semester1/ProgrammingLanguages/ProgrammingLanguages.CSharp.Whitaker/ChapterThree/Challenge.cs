namespace ProgrammingLanguages.CSharp.Whitaker.ChapterThree;

public static class Challenge
{
    public static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void WhatComesNext()
    {
        Console.WriteLine("Hello, Stranger!");
    }

    public static void TheMakingsofaProgrammer()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void ConsolasAndTelim()
    {
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is this bread for?");
        var playerName = Console.ReadLine();
        Console.WriteLine($"Noted: {playerName} got the bread.");
    }
}
