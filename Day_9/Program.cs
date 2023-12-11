// See https://aka.ms/new-console-template for more information
using Day_9;

const string inputFileName = "InputData.txt";
Console.WriteLine("Next: " + Interactor.SummarizeExtrapolatedNextValues(inputFileName));
Console.WriteLine("Previous: " + Interactor.SummarizeExtrapolatedPreviousValues(inputFileName));