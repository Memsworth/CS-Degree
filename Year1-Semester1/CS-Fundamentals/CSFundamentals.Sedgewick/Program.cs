// See https://aka.ms/new-console-template for more information
using CSFundamentals.Sedgewick.Chapter1;

if (args.Length == 0)
{
    System.Console.WriteLine("Give me an args");
//    return;
}

var exercise = new Exercise2_28();
exercise.Run(args);