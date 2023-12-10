namespace Day_7;

public static class PokerHandSorter
{

    public static IEnumerable<Hand> SortHands(
        IEnumerable<Hand> hands, 
        Func<Hand, int> typeValueCalculator, 
        IReadOnlyDictionary<char, int> cardValueDictionary)
    {
        return hands
            .OrderBy(x => x, new HandByTypeComparer(typeValueCalculator))
            .ThenBy(x => x, new HandByHighCardComparer(cardValueDictionary));
    }
}