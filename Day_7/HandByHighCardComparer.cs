namespace Day_7;

public class HandByHighCardComparer : IComparer<Hand>
{
    private readonly IReadOnlyDictionary<char, int> _cardValueDictionary;


    public HandByHighCardComparer(IReadOnlyDictionary<char, int> cardValueDictionary)
    {
        _cardValueDictionary = cardValueDictionary;
    }

    public int Compare(Hand? x, Hand? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        for (int i = 0; i < x.Cards.Count; i++)
        {
            var cardValueX = _cardValueDictionary[x.Cards[i]];
            var cardValueY = _cardValueDictionary[y.Cards[i]];
            var compareResult = cardValueX.CompareTo(cardValueY);
            if (compareResult != 0)
            {
                return compareResult;
            }
        }
        return 0;
    }
}
