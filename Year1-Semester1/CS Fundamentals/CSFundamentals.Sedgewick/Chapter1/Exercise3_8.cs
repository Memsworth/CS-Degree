using System;

namespace CSFundamentals.Sedgewick.Chapter1;

public class Exercise3_8 : IExercise
{
    public void Run(string[] args)
    {
        var valToIterate = int.Parse(args[0]);
        var iterator = 1;
        while(iterator <= valToIterate)
        {
            string form;
            if (iterator % 100 >= 11 && iterator % 100 <= 13)
                form = "th";

            else if (iterator % 10 == 1 || iterator % 100 == 1)
                form = "st";

            else if (iterator % 10 == 2 || iterator % 100 == 2)
                form = "nd";

            else if (iterator % 10 == 3 || iterator % 100 == 3)
                form = "rd";

            else
                form = "th";


            System.Console.WriteLine($"{iterator}{form} Hello");
            iterator++;
        }
    }
}
