namespace Day_7;

public static class PokerHandSorter
{

    public static IEnumerable<Hand> SortHands(IEnumerable<Hand> hands)
    {
        return hands
            .OrderByDescending(x => x, new HandByTypeComparer(HandValueCalculator.CalculateHandValue))
            .ThenByDescending(x => x, new HandByHighCardComparer());
    }
}