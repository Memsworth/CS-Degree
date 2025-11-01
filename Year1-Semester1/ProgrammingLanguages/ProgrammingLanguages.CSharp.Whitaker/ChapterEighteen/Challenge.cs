namespace ProgrammingLanguages.CSharp.Whitaker.ChapterEighteen;

public static class Challenge
{
    public static void VinFletcherArrows()
    {
        Console.WriteLine("Creating an arrow");

        var arrowHead = GetArrowHead();
        var fletching = GetFlitch();
        Console.WriteLine("Enter a range for arrow");
        var len = GetNumInRange(1, 10);

        var arrow = new Arrow(arrowHead, fletching, len);

        Console.WriteLine($"Cost of arrow: {arrow.GetCost()} gold");
        
    }

    

    private static ArrowHead GetArrowHead()
    {
        var arrowHead = new ArrowHead();
        Console.WriteLine("Type of arrow head: ");
        Console.WriteLine($"1: {ArrowHead.Steel.ToString()}");
        Console.WriteLine($"2: {ArrowHead.Wood.ToString()}");
        Console.WriteLine($"3: {ArrowHead.Obsidian.ToString()}");

        switch(GetNumInRange(0, 4))
        {
            case 1:
                arrowHead = ArrowHead.Steel;
                break;
            case 2:
                arrowHead =  ArrowHead.Wood;
                break;
            case 3:
                arrowHead =  ArrowHead.Obsidian;
                break;
        }

        return arrowHead;
    }

    private static Fletching GetFlitch()
    {
        var fletch = new Fletching();
        Console.WriteLine("Type of Fletching: ");
        Console.WriteLine($"1: {Fletching.Plastic.ToString()}");
        Console.WriteLine($"2: {Fletching.Turkey.ToString()}");
        Console.WriteLine($"3: {Fletching.Goose.ToString()}");

        switch (GetNumInRange(0, 4))
        {
            case 1:
                fletch = Fletching.Plastic;
                break;
            case 2:
                fletch = Fletching.Turkey;
                break;
            case 3:
                fletch = Fletching.Goose;
                break;
        }

        return fletch;
    }

    private static int GetNumInRange( int min, int max )
    {
        var item = 0;
        while (true)
        {
            item = int.Parse(Console.ReadLine());
            if (item > min && item < max)
                return item;
        }
    }
}

public class Arrow
{
    public ArrowHead _ArrowHead { get; private set; }
    public Fletching _Fletching { get; private set; }
    public float Length { get; private set; }

    public Arrow(ArrowHead arrowHead, Fletching fletching, float length)
    {
        _ArrowHead = arrowHead;
        _Fletching = fletching;
        Length = length;
    }
    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, Fletching.Goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.Goose, 65);

    public float GetCost()
    {
        var total = 0f;

        switch(_ArrowHead)
        {
            case ArrowHead.Steel:
                total += 10;
                break;
            case ArrowHead.Wood:
                total += 3;
                break;
            case ArrowHead.Obsidian:
                total += 5;
                break;
        }

        switch(_Fletching)
        {
            case Fletching.Plastic:
                total += 10;
                break;
            case Fletching.Turkey:
                total += 5;
                break;
            case Fletching.Goose:
                total += 3;
                break;
        }

        total += Length * 0.05f;

        return total;
    }
}

public enum ArrowHead
{
    Steel,
    Wood,
    Obsidian
}

public enum Fletching
{
    Plastic,
    Turkey,
    Goose
}