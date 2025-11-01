namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentyNine;

public static class Challenge
{
    public static void WarPreparations()
    {
        var basic = new Sword(Material.Wood, Gemstone.none, 10, 10);

        Console.WriteLine(basic);

        var variant1 = basic with
        {
            Material = Material.Iron,
            Gemstone = Gemstone.Amber,
        }; 
        
        var variant2 = basic with
        {
            Material = Material.Steel,
            Gemstone = Gemstone.Bitstone,
        };


        Console.WriteLine(variant1);
        Console.WriteLine(variant2);
    }
}

public enum Material
{
    Wood,
    Bronze,
    Iron,
    Steel
}

public enum Gemstone
{
    Emerald, Amber, Sapphire, Diamond, Bitstone, none
}

public record Sword(Material Material, Gemstone Gemstone, int Length, int Width)
{
    public override string ToString()
    {
        return $"A sword made out of {Material}, imbued with {Gemstone}, " +
            $"Length of {Length}cm and crossguard of {Width}cm";
    }
};