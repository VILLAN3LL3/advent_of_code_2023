namespace Day_9
{
    public static class ValueHistoryExtrapolator
    {
        public static long ExtrapolateHistoryEntry(List<List<long>> historyEntries, bool previous)
        {
            var nextEntries = new List<long>();
            List<long> lastEntries = historyEntries.Last();
            for (int i = 0; i < lastEntries.Count - 1; i++)
            {
                nextEntries.Add(lastEntries[i + 1] - lastEntries[i]);
            }
            historyEntries.Add(nextEntries);
            if (nextEntries.All(entries => entries.Equals(0L)))
            {
                return previous ? FindPreviousVale(historyEntries) : FindNextValue(historyEntries);
            }
            return ExtrapolateHistoryEntry(historyEntries, previous);
        }

        private static long FindNextValue(List<List<long>> historyEntries)
        {
            long result = historyEntries.Last().Last();
            for (int i = historyEntries.Count - 2; i >= 0; i--)
            {
                result += historyEntries[i].Last();
            }
            return result;
        }

        private static long FindPreviousVale(List<List<long>> historyEntries)
        {
            long result = historyEntries.Last()[0];
            for (int i = historyEntries.Count - 2; i >= 0; i--)
            {
                result = historyEntries[i][0] - result;
            }
            return result;
        }
    }
}