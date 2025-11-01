namespace ProgrammingLanguages.CSharp.Whitaker.ChapterEleven;

public static class Challenge
{
    public static void Prototype()
    {
        var isGame = false;
        int guessKey = 0;
        do
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            guessKey = int.Parse(Console.ReadLine());
        } while (guessKey < 0 || guessKey > 100);

        while (isGame is false)
        {
            Console.Write("User 2, guess the number.");
            Console.Write("What is your next guess? ");
            int.TryParse(Console.ReadLine(), out int userGuess);

            if (userGuess > guessKey)
                Console.WriteLine($"{userGuess} is too high.");

            if (userGuess < guessKey)
                Console.WriteLine($"{userGuess} is too low.");

            if (userGuess == guessKey)
            {
                Console.WriteLine("You guessed the number!");
                isGame = true;
            }
        }
    }


    public static void MagicCannon()
    {
        for (int i = 1; i < 101; i++)
        {
            if (i % 3 == 0 & i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i}: Electric and Fire");
            }
            else if (i % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i}: Fire");
            }
            else if (i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i}: Electric");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{i}: Normal");
            }
        }
    }
}
