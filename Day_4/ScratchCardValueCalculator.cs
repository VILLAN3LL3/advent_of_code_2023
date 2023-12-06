namespace Day_4;

public static class ScratchCardValueCalculator
{
    public static int CalculateScratchCardValue(ScratchCard scratchCard)
    {
        var matchingNumbers = scratchCard.WinningNumbers.Intersect(scratchCard.UserNumbers).Count();
        return (int)Math.Pow(2, matchingNumbers - 1);
    }
}
