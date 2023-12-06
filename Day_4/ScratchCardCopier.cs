namespace Day_4;

public static class ScratchCardCopier
{
    public static List<ScratchCardWithCopies> CopyScratchCards(List<ScratchCard> scratchCards)
    {
        var dict = scratchCards.ToDictionary(scratchCard => scratchCard.CardId, scratchCard => new ScratchCardWithCopies(scratchCard));

        foreach (ScratchCardWithCopies scratchCard in dict.Values)
        {
            for (int i = scratchCard.CardId + 1; i <= scratchCard.CardId + scratchCard.MatchingNumbers; i++)
            {
                dict[i].CopyCount += scratchCard.CopyCount;
            }
        }
        return dict.Values.ToList();
    }
}
