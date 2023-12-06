namespace Day_4;

public class ScratchCardWithCopies : ScratchCard
{
    public ScratchCardWithCopies(ScratchCard scratchCard)
    {
        CardId = scratchCard.CardId;
        WinningNumbers = scratchCard.WinningNumbers;
        UserNumbers = scratchCard.UserNumbers;
    }

    public ScratchCardWithCopies(ScratchCard scratchCard, int copyCount) : this(scratchCard)
    {
        CopyCount = copyCount;
    }
    
    public int CopyCount { get; set; } = 1;

    public  int MatchingNumbers => WinningNumbers.Intersect(UserNumbers).Count();

}
