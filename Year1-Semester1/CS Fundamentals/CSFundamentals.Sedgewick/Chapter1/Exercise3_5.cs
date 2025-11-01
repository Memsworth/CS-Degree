using System;

namespace CSFundamentals.Sedgewick.Chapter1;

public class Exercise3_5 : IExercise
{
    public void Run(string[] args)
    {
        var rand = new Random();

        var roll = rand.NextDouble();
        int dieRoll;

        if (roll > 0.0 && roll < 0.125)
            dieRoll = 1;

        else if (roll > 0.125 && roll < 0.25)
            dieRoll = 2;

        else if (roll > 0.25 && roll < 0.375)
            dieRoll = 3;


        else if (roll > 0.375 && roll < 0.5)
            dieRoll = 4;

        else if (roll > 0.5 && roll < 0.625)
            dieRoll = 5;

        else
            dieRoll = 6;

        System.Console.WriteLine($"{dieRoll}");
    }
}
