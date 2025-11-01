namespace ProgrammingLanguages.CSharp.Whitaker.ChapterThirty;

public class Challenge
{
    public static void ColoredItems()
    {
        var item1 = new ColoredItem<Sword>(new Sword(), ConsoleColor.Red);
        var item2 = new ColoredItem<Bow>(new Bow(), ConsoleColor.Blue);
        var item3 = new ColoredItem<Axe>(new Axe(), ConsoleColor.Yellow);

        item1.Display();
        item2.Display();
        item3.Display();
    }
}

public class Sword 
{
    public override string ToString() => "Sword";
}
public class Bow
{
    public override string ToString() => "Bow";
}
public class Axe
{
    public override string ToString() => "Axe";
}

public class ColoredItem<T>
{
    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public T Item { get; set; }
    public ConsoleColor Color { get; set; }
    public void Display()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = Color;
        Console.WriteLine($"A {Color} {Item}");
        Console.ForegroundColor = previousColor;
    }
}
