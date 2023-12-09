using Shared;

namespace Day_7
{
    public static class Interactor
    {
        public static int CalculateTotalWinnings(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Hand> hands = HandMapper.MapHands(lines);
            IEnumerable<Hand> sortedHands = PokerHandSorter.SortHands(hands);
            return WinningsCalculator.CalculateWinnings(sortedHands);
        }
    }
}