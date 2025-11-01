namespace ProgrammingLanguages.CSharp.Whitaker.ChapterFourteen;

public static class Challenge
{
    public static void StartGame()
    {
        Console.Title = "Hunting the Manticore";
        const int mantiMaxHp = 15;
        int currentMantiHp = 15;

        const int cityMaxHp = 10;
        int currentCityHp = 10;

        const int cannonMinDmg = 1;
        const int cannonMaxDmg = 3;
        int currentRound = 1;
        var isGame = true;
        
        int mantiLocation = 
            AskNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
        Console.Clear();

        while (isGame)
        {
            int cannonDmg;
            if (currentRound % 3 == 0)
                cannonDmg = cannonMaxDmg;
            else
                cannonDmg = cannonMinDmg;

            DisplayUI(currentRound, currentCityHp, cityMaxHp, currentMantiHp, mantiMaxHp, cannonDmg);
            var playerTwoInput = AskNumberInRange("Enter desired cannon range: ", 0, 100);

            if (playerTwoInput > mantiLocation)
            {
                Console.WriteLine("That round OVERSHOT the target.");
                currentCityHp--;
            }
            else if(playerTwoInput < mantiLocation)
            {
                Console.WriteLine("That round FELL SHORT of the target.");
                currentCityHp--;
            }
            else
            {
                Console.WriteLine("That round was a DIRECT HIT!");
                currentCityHp--;
                currentMantiHp -= currentRound % 3 == 0 ? cannonMaxDmg : cannonMinDmg;
            }
            
            currentRound++;

            if (currentCityHp < 1 || currentMantiHp < 1)
                isGame = false;
        }

        if (currentMantiHp <= 0)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved! ");
        }
        else
        {
            Console.WriteLine("The city of Consolas has fallen!");
        }
    }

    private static int AskNumberInRange(string text, int min, int max)
    {
        while (true)
        {
            Console.Write($"{text}");
            int.TryParse(Console.ReadLine(), out var userInput);
            if (userInput > min && userInput < max)
                return userInput;
        }
    }

    private static void DisplayUI(int round, int currentCityHp, int cityMaxHp, int currentMantiHp, int MantiMaxHp, int currentCannonDmg)
    {
        Console.WriteLine("---------------------------------------------------------- ");
        Console.WriteLine($"STATUS: Round: {round}  City: {currentCityHp}/{cityMaxHp}  Manticore: {currentMantiHp}/{MantiMaxHp} ");
        Console.WriteLine($"The cannon is expected to deal {currentCannonDmg} damage this round. \r\n");
    }
}
