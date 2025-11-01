namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwelve;

public static class Challenge
{
    public static void TheReplicatorOfDTO()
    {
        var inputArray = new int[5];

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out inputArray[i]);
        }

        var inputArray2 = new int[inputArray.Length];

        for (int i = 0;i < inputArray2.Length; i++)
            inputArray2[i] = inputArray[i];

        Console.Write($"Array1: ");
        for (int i = 0; i< inputArray.Length ; i++)
        {
            Console.Write($"{inputArray[i]}");
        }

        Console.Write($"\nArray2: ");
        for (int i = 0; i < inputArray2.Length; i++)
        {
            Console.Write($"{inputArray2[i]}");
        }
    }

    public static void TheLawsOfFreach()
    {
        var array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

        var currentSmallest = int.MaxValue;
        int total = 0;

        foreach (var i in array)
        {
            total += i;
            if (i < currentSmallest)
            {
                currentSmallest = i;
            }
        }
        var avg = (float)total / array.Length;
        Console.WriteLine($"avg: {avg}");
        Console.WriteLine($"small: {currentSmallest}");
        Console.WriteLine($"total: {total}");
    }
}
