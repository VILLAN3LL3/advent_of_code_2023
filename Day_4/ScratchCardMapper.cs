namespace Day_4;

public static class ScratchCardMapper
{
    private static readonly char[] cratchCardSeparators = [':', '|'];
    private static readonly string[] scratchCardNumberSeparator = ["  ", " "];

    public static ScratchCard MapScratchCard(string scratchCardLine)
    {
        var scratchCardObject = new ScratchCard();
        var scratchCardSplit = scratchCardLine
            .Split(cratchCardSeparators, StringSplitOptions.TrimEntries);
        scratchCardObject.CardId = int.Parse(scratchCardSplit[0][5..]);
        scratchCardObject.WinningNumbers = scratchCardSplit[1]
            .Split(scratchCardNumberSeparator, StringSplitOptions.TrimEntries)
            .Select(int.Parse)
            .ToList();
        scratchCardObject.UserNumbers = scratchCardSplit[2]
            .Split(scratchCardNumberSeparator, StringSplitOptions.TrimEntries)
            .Select(int.Parse)
            .ToList();
        return scratchCardObject;
    }
}
