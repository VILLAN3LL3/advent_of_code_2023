// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Day_8;

const string inputFileName = "InputData.txt";
Console.WriteLine("Part 1: " + Interactor.CalculateStepCountToGoal(inputFileName));
Console.WriteLine("Part 2: " + Interactor.CalculateStepCountToGoalForGhosts(inputFileName));
