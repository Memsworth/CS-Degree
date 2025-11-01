namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTen;

public static class Challenge
{
    public static void BuyingInventory()
    {
        Console.WriteLine("The following items are available: ");
        Console.WriteLine("1 – Rope");
        Console.WriteLine("2 – Torches");
        Console.WriteLine("3 – Climbing Equipment");
        Console.WriteLine("4 – Clean Water");
        Console.WriteLine("5 – Machete");
        Console.WriteLine("6 – Canoe");
        Console.WriteLine("7 – Food Supplies");

        Console.Write("What number do you want to see the price of? ");
        int.TryParse(Console.ReadLine(), out int id);
        int goldCost = id switch
        {
            1 => 10,
            2 => 15,
            3 => 25,
            4 => 1,
            5 => 20,
            6 => 200,
            7 => 1,
            _ => 0
        };

        Console.WriteLine($"cost: {goldCost} gold");
    }


    public static void DiscountedInventory()
    {
        Console.WriteLine("The following items are available: ");
        Console.WriteLine("1 – Rope");
        Console.WriteLine("2 – Torches");
        Console.WriteLine("3 – Climbing Equipment");
        Console.WriteLine("4 – Clean Water");
        Console.WriteLine("5 – Machete");
        Console.WriteLine("6 – Canoe");
        Console.WriteLine("7 – Food Supplies");

        Console.Write("What number do you want to see the price of? ");
        int.TryParse(Console.ReadLine(), out int id);
        int goldCost = id switch
        {
            1 => 10,
            2 => 15,
            3 => 25,
            4 => 1,
            5 => 20,
            6 => 200,
            7 => 1,
            _ => 0
        };

        Console.WriteLine("What is your name?");
        var name = "Ahmed";
        var userInput = Console.ReadLine();
        if (userInput == name)
            Console.WriteLine($"cost: {goldCost / 2} gold");
        else
            Console.WriteLine($"cost: {goldCost} gold");
    }
}
