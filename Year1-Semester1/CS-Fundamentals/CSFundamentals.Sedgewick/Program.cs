// See https://aka.ms/new-console-template for more information
using CSFundamentals.Sedgewick.Chapter1;
using CSFundamentals.Sedgewick.Chapter1.Section4;

if (args.Length == 0)
{
    System.Console.WriteLine("Give me an args");
}

IExercise exercise = new Exercise4_12();
exercise.Run(args);