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

    public static int CalculateTotalScratchCardCount(string fileName) {
        var lines = InputDataLoader.LoadInputData(fileName);
        List<ScratchCard> scratchCards = ScratchCardMapper.MapScratchCards(lines);
        List<ScratchCardWithCopies> scratchCardsWithCopies = ScratchCardCopier.CopyScratchCards(scratchCards);
        return ScratchCardCopySummarizer.SummarizeScratchCardCopies(scratchCardsWithCopies);
    }
}
