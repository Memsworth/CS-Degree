// See https://aka.ms/new-console-template for more information
using CSFundamentals.Sedgewick.Chapter1;
using CSFundamentals.Sedgewick.Chapter1.Section3;

if (args.Length == 0)
{
    System.Console.WriteLine("Give me an args");
}

IExercise exercise = new Exercise3_42();
exercise.Run(args);