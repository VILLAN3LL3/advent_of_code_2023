// See https://aka.ms/new-console-template for more information
using Day_5;

foreach (string statusMessage in Interactor.CalculateMinimumLocation("InputData.txt"))
{
    Console.WriteLine(statusMessage);
}
Console.ReadLine();
