namespace ProgrammingLanguages.CSharp.Whitaker.ChapterThirteen;

public static class Challenge
{
    public static void TakingNumber()
    {
        int result = AskForNumber("What is the airspeed velocity of an unladen swallow ? ");
        Console.WriteLine($"result = {result}");

        result = AskForNumberInRange("num in range", 0, 100);
        Console.WriteLine($"result = {result}");
    }

    private static int AskForNumber(string text)
    {
        Console.WriteLine($"{text}");
        int.TryParse(Console.ReadLine(), out int result);
        return result;
    }

    private static int AskForNumberInRange(string text, int min, int max)
    {
        while(true)
        {
            Console.WriteLine($"{text}");
            int.TryParse(Console.ReadLine(), out int result);
            if( result >= min && result <= max )
                return result;
        }
    }


    public static void Countdown(int number)
    {
        if (number == 0)
        {
            Console.WriteLine("BOOM");
            return;
        }
        Console.WriteLine(number);
        Countdown(number - 1);
    }
}
