namespace ProgrammingLanguages.CSharp.Whitaker.ChapterSeven;

public static class Challenge
{
    public static void TheTriangleFarmer()
    {
        Console.Write("Enter a base value for the triangle: ");
        int.TryParse(Console.ReadLine(), out int TriBase);

        Console.Write("Enter a height value for the triangle: ");
        int.TryParse(Console.ReadLine(), out int TriHeight);

        double area = TriBase * TriHeight / 2;

        Console.WriteLine($"A triangle of base {TriBase} & height of {TriHeight} has an area of {area}.");
    }

    public static void TheFourSistersAndTheDuckbear()
    {
        Console.Write("Enter the number of chocolate eggs harvested today: ");
        int.TryParse(Console.ReadLine(), out int Eggs);

        int sisterEggs = Eggs / 4;
        int duckBearEggs = Eggs % 4;

        Console.WriteLine($"The number of eggs harvested by the four sisters is {sisterEggs}.");
        Console.WriteLine($"The number of eggs harvested by the duckbear is {duckBearEggs}.");
    }

    public static void TheDominionOfKings()
    {
        const int estate = 1;
        const int duchy = 3;
        const int province = 6;

        Console.Write("How many estates: ");
        int.TryParse(Console.ReadLine(), out int estateInput);

        Console.Write("How many duchies: ");
        int.TryParse(Console.ReadLine(), out int duchyInput);

        Console.Write("How many provinces: ");
        int.TryParse(Console.ReadLine(), out int provinceInput);

        var totalPoints = estate * estateInput
            + duchy * duchyInput + province * provinceInput;

        Console.WriteLine($"total points = {totalPoints}");
    }
}
