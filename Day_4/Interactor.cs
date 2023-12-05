using Shared;

namespace Day_4;

public static class Interactor
{
    public static int CalculateTotalValueOfScratchCards(string fileName) {
        var lines = InputDataLoader.LoadInputData(fileName);
        var result = 0;
        foreach (string line in lines)
        {
            ScratchCard scratchCard = ScratchCardMapper.MapScratchCard(line);
            result += ScratchCardValueCalculator.CalculateScratchCardValue(scratchCard);
        }
        return result;
    }
}
