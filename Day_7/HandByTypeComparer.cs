namespace Day_7;

public class HandByTypeComparer : IComparer<Hand>
{
    private readonly Func<Hand, int> _handValueCalculator;

    public HandByTypeComparer(Func<Hand, int> handValueCalculator)
    {
        _handValueCalculator = handValueCalculator;
    }

    public int Compare(Hand? x, Hand? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }
        int handXValue = _handValueCalculator(x);
        int handYValue = _handValueCalculator(y);

        return handYValue.CompareTo(handXValue);
    }
}
