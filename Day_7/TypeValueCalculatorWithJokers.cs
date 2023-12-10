namespace Day_7
{
    public static class TypeValueCalculatorWithJokers
    {
        public static int CalculateTypeValue(Hand hand)
        {
            var cards = new List<char>(hand.Cards);
            var jokerCount = cards.RemoveAll(x => x == 'J');
            return CalculateValueFromFrequency(CountCardValueFrequency(cards), jokerCount);
        }

        private static int CalculateValueFromFrequency(List<int> frequency, int jokerCount)
        {
            return int.Parse(string.Join("", frequency).PadRight(5, '0')) + jokerCount * 10000;
        }

        private static List<int> CountCardValueFrequency(List<char> cards)
        {
            return cards.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Count()).ToList();
        }
    }
}