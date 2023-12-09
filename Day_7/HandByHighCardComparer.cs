namespace Day_7;

public class HandByHighCardComparer : IComparer<Hand>
{
    public int Compare(Hand? x, Hand? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        for (int i = 0; i < x.Cards.Count; i++)
        {
            var cardValueX = Config.CardValueDictionary[x.Cards[i]];
            var cardValueY = Config.CardValueDictionary[y.Cards[i]];
            var compareResult = cardValueY.CompareTo(cardValueX);
            if (compareResult != 0)
            {
                return compareResult;
            }
        }
        return 0;
    }
}
