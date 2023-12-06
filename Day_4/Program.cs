// See https://aka.ms/new-console-template for more information
using Day_4;

const string fileName = "InputData.txt";
Console.WriteLine("Total value of scratch cards: " + Interactor.CalculateTotalValueOfScratchCards(fileName));
Console.WriteLine("Total count of scratch cards with copies: " + Interactor.CalculateTotalScratchCardCount(fileName));
Console.ReadLine();
