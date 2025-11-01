namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentyFive;

public static class Challenge
{
    public static void PackingInventory()
    {
        // Create a new pack with a limit of 5 items, 10 weight, and 15 volume
        var myPack = new Pack(5, 10, 15);

        // Item menu
        Console.WriteLine("Welcome to the Inventory System.");
        Console.WriteLine("You can add the following items to your pack:");
        Console.WriteLine("1. Arrow");
        Console.WriteLine("2. Bow");
        Console.WriteLine("3. Rope");
        Console.WriteLine("4. Water");
        Console.WriteLine("5. Food Ration");
        Console.WriteLine("6. Sword");
        Console.WriteLine("7. Quit");

        var running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an item to add (1-7):");
            var choice = Console.ReadLine();

            InventoryItem itemToAdd = null;

            switch (choice)
            {
                case "1":
                    itemToAdd = new Arrow();
                    break;
                case "2":
                    itemToAdd = new Bow();
                    break;
                case "3":
                    itemToAdd = new Rope();
                    break;
                case "4":
                    itemToAdd = new Water();
                    break;
                case "5":
                    itemToAdd = new Food();
                    break;
                case "6":
                    itemToAdd = new Sword();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    continue;
            }

            if (itemToAdd != null)
            {
                var added = myPack.Add(itemToAdd);
                if (added)
                    Console.WriteLine("Item added successfully.");
                else
                    Console.WriteLine("Failed to add item: Pack limit exceeded.");
            }

            // Display current pack status
            Console.WriteLine($"\nCurrent Pack Status:");
            Console.WriteLine($"Items in Pack: {myPack.GetCurrentCount()}");
            Console.WriteLine($"Total Weight: {myPack.GetCurrentWeight()}");
            Console.WriteLine($"Total Volume: {myPack.GetCurrentVolume()}");
        }

        Console.WriteLine("Thank you for using the inventory system!");
    }
}

#region GameClass
public class InventoryItem
{
    public double Weight { get; private set; }
    public double Volume { get; private set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
    public InventoryItem() { }
}

public class Arrow : InventoryItem
{
    public Arrow(double weight, double volume) : base(weight, volume) { }
    public Arrow() : base(0.1, 0.05) { }
}

public class Bow : InventoryItem
{
    public Bow(double weight, double volume) : base(weight, volume) { }
    public Bow() : base(1, 4) { }
}

public class Rope : InventoryItem
{
    public Rope(double weight, double volume) : base(weight, volume) { }
    public Rope() : base(1, 1.5) { }
}
public class Water : InventoryItem
{
    public Water(double weight, double volume) : base(weight, volume) { }
    public Water() : base(2, 3) { }
}
public class Food : InventoryItem
{
    public Food(double weight, double volume) : base(weight, volume) { }
    public Food() : base(1, 0.5) { }
}
public class Sword : InventoryItem
{
    public Sword(double weight, double volume) : base(weight, volume) { }
    public Sword() : base(5, 3) { }
}

public class Pack
{
    public InventoryItem[] Items { get; private set; }
    public double MaxWeight { get; private set; }
    public double MaxVolume { get; private set; }
    private int CurrentItems { get; set; }
    private double CurrentWeight { get; set; }
    private double CurrentVolume { get; set; }
    public Pack(int itemsCount, double maxWeight, double maxVolume)
    {
        Items = new InventoryItem[itemsCount];
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
        CurrentItems = 0;
        CurrentVolume = 0;
        CurrentWeight = 0;
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentItems >= Items.Length)
            return false;

        if (CurrentWeight + item.Weight >= MaxWeight)
            return false;

        if (CurrentVolume + item.Volume >= MaxVolume)
            return false;

        Items[CurrentItems++] = item;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        return true;
    }

    public int GetCurrentCount() => CurrentItems;
    public double GetCurrentVolume() => CurrentVolume;
    public double GetCurrentWeight() => CurrentWeight;
}
#endregion