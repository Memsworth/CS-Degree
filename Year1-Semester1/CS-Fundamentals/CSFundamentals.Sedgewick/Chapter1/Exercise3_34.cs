namespace CSFundamentals.Sedgewick.Chapter1;

public class Exercise3_34 : IExercise
{
    
    //TODO: Bad solution. Refactor this solution
    public void Run(string[] args)
    {
        var n = int.Parse(args[0]);
        var cubeRoot = Math.Floor(Math.Cbrt(n));
        for (int i = 0; i < cubeRoot; i++)
        {
            for (int j = 0; j < cubeRoot; j++)
            {
                var total = Math.Pow(i, 3) + Math.Pow(j, 3);
                if (total == n)
                {
                    System.Console.WriteLine($"{i} - {j}");
                }
            }
        }
        

        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j< n; j++)
            {
                for (int k = 0; k < cubeRoot; k++)
                {
                    for (int b = 0; b < cubeRoot; b++)
                    {
                        var total = Math.Pow(i, 3) + Math.Pow(j, 3);
                        if (total == n)
                        {
                            System.Console.WriteLine($"{i} - {j}");
                        }
                    }
                }
            }
        }
    }
}