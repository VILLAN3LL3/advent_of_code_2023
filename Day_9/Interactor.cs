using Shared;

namespace Day_9
{
    public static class Interactor
    {
        public static long SummarizeExtrapolatedNextValues(string inputFileName)
        {
            var input = InputDataLoader.LoadInputData(inputFileName);
            List<ValueHistory> valueHistories = ValueHistoryMapper.MapToValueHistory(input);
            long extrapolatedValues = 0;
            foreach (ValueHistory history in valueHistories)
            {
                extrapolatedValues += ValueHistoryExtrapolator.ExtrapolateHistoryEntry([history.HistoryEntries], false);
            }
            return extrapolatedValues;
        }

        public static long SummarizeExtrapolatedPreviousValues(string inputFileName)
        {
            var input = InputDataLoader.LoadInputData(inputFileName);
            List<ValueHistory> valueHistories = ValueHistoryMapper.MapToValueHistory(input);
            long extrapolatedValues = 0;
            foreach (ValueHistory history in valueHistories)
            {
                extrapolatedValues += ValueHistoryExtrapolator.ExtrapolateHistoryEntry([history.HistoryEntries], true);
            }
            return extrapolatedValues;
        }
    }
}