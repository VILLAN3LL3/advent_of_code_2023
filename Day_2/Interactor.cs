using Shared;

namespace Day_2;

public static class Interactor
{
    public static int CalculateIdSumOfPossibleGamesForGivenBag(Bag bag, string inputFileName)
    {
        var input = InputDataLoader.LoadInputData(inputFileName);

        var result = 0;
        foreach (var line in input)
        {
            Game game = GameMapper.MapLineToGame(line);
            if (GamePlausibilityChecker.IsGamePossible(bag, game))
            {
                result += game.Id;
            }

        }
        return result;
    }
}
