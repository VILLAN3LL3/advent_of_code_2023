// See https://aka.ms/new-console-template for more information
using Day_7;

const string InputFileName = "InputData.txt";
Console.WriteLine("Without jokers: " + Interactor.CalculateTotalWinnings(InputFileName));
Console.WriteLine("With jokers: " + Interactor.CalculateTotalWinningsWithJokers(InputFileName));

