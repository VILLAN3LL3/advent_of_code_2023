namespace Day_4;

public static class ScratchCardCopySummarizer
{
    public static int SummarizeScratchCardCopies(List<ScratchCardWithCopies> scratchCardsWithCopies)
    {
        return scratchCardsWithCopies.Sum(scratchCard => scratchCard.CopyCount);
    }
}