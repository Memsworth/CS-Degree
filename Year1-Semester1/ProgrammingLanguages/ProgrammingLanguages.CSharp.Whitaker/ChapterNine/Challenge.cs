namespace ProgrammingLanguages.CSharp.Whitaker.ChapterNine;

public static class Challenge
{
    public static void RepairingTheClocktower()
    {
        Console.Write("Enter a number: ");
        int.TryParse(Console.ReadLine(), out int clocktower);
        if (clocktower % 2 == 0)
            Console.WriteLine("Tick");
        else
            Console.WriteLine("Tock");
    }

    public static void Watchtower()
    {
        Console.Write("Y position: ");
        int.TryParse(Console.ReadLine(), out int posY);

        Console.Write("X position: ");
        int.TryParse(Console.ReadLine(), out int posX);

        if (posX > 0 && posY > 0)
            Console.WriteLine("The enemy is to the northeast!");
        if (posX == 0 && posY > 0)
            Console.WriteLine("The enemy is to the north!");
        if (posX < 0 && posY > 0)
            Console.WriteLine("The enemy is to the northwest!");

        if (posX > 0 && posY == 0)
            Console.WriteLine("The enemy is to the east!");
        if (posX == 0 && posY == 0)
            Console.WriteLine("The enemy is here!");
        if (posX < 0 && posY == 0)
            Console.WriteLine("The enemy is to the west!");


        if (posX > 0 && posY < 0)
            Console.WriteLine("The enemy is to the southeast!");
        if (posX == 0 && posY < 0)
            Console.WriteLine("The enemy is to the south!");
        if (posX < 0 && posY < 0)
            Console.WriteLine("The enemy is to the southwest!");
    }
}
