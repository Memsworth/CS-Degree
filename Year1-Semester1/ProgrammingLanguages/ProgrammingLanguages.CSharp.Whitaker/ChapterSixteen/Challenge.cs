namespace ProgrammingLanguages.CSharp.Whitaker.ChapterSixteen;

public static class Challenge
{
    public static void SimulaTest()
    {
        var chest = ChestState.Locked;

        while (true)
        {
            printState(chest);
            var input = Console.ReadLine();
            chest = ChangeState(input, chest);
        }
    }

    private static ChestState ChangeState(string? input, ChestState currentState)
    {
        ChestState state;

        switch(input)
        {
            case "close" when currentState == ChestState.Open:
                state = ChestState.Closed;
                break;

            case "lock" when currentState == ChestState.Closed:
                state = ChestState.Locked;
                break;

            case "unlock" when currentState == ChestState.Locked:
                state = ChestState.Closed;
                break;

            case "open" when currentState == ChestState.Closed:
                state = ChestState.Open;
                break;
            
            default:
                state = currentState; 
                break;
        }
        return state;
    }

    private static void printState(ChestState chest)
    {
        Console.Write($"The chest is {chest.ToString().ToLower()}. What do you want to do? ");
    }
    public enum ChestState
    {
        Open,
        Closed,
        Locked
    }

}