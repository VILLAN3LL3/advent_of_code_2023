namespace Day_7;

public class HandByTypeComparer : IComparer<Hand>
{
    private readonly Func<Hand, int> _typeValueCalculator;

    public HandByTypeComparer(Func<Hand, int> typeValueCalculator)
    {
        _typeValueCalculator = typeValueCalculator;
    }

    public int Compare(Hand? x, Hand? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }
        int handXValue = _typeValueCalculator(x);
        int handYValue = _typeValueCalculator(y);

        return handXValue.CompareTo(handYValue);
    }
}
