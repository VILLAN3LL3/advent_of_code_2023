// See https://aka.ms/new-console-template for more information
using Day_2;

var inputDataFileName = "InputData.txt";
Console.WriteLine(
    "Id Sum of Possible Games for Given Bag: " 
    + Interactor.CalculateIdSumOfPossibleGamesForGivenBag(new Bag(12, 14, 13), inputDataFileName));
Console.WriteLine(
    "Power of Games: "
    + Interactor.CalculateTotalPowerOfGames(inputDataFileName));
Console.ReadLine();
