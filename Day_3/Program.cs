// See https://aka.ms/new-console-template for more information
using Day_3;

const string inputDataFileName = "InputData.txt";
Console.WriteLine("Sum of all part numbers in engine schematics: " + Interactor.SumAllPartNumbersInEngineSchematics(inputDataFileName));
Console.WriteLine("Sum of all gear ratios in engine schematics: " + Interactor.SumAllGearRatiosInEngineSchematics(inputDataFileName));
Console.ReadLine();
