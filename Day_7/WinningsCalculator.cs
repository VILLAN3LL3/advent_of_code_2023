namespace Day_7
{
    public static class WinningsCalculator
    {
        public static int CalculateWinnings(IEnumerable<Hand> sortedHands)
        {
            return sortedHands
                .Select((hand, index) => hand.Bid * (index + 1))
                .Sum();
        }
    }
}