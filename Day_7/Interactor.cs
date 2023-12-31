using Shared;

namespace Day_7
{
    public static class Interactor
    {
        public static int CalculateTotalWinnings(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Hand> hands = HandMapper.MapHands(lines);
            IEnumerable<Hand> sortedHands = PokerHandSorter.SortHands(hands, TypeValueCalculator.CalculateTypeValue, Config.CardValueDictionary);
            return WinningsCalculator.CalculateWinnings(sortedHands);
        }

        public static int CalculateTotalWinningsWithJokers(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Hand> hands = HandMapper.MapHands(lines);
            IEnumerable<Hand> sortedHands = PokerHandSorter.SortHands(hands, TypeValueCalculatorWithJokers.CalculateTypeValue, Config.CardValueDictionaryWithJoker);
            return WinningsCalculator.CalculateWinnings(sortedHands);
        }
    }
}