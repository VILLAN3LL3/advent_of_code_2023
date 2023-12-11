namespace Day_9
{
    public static class ValueHistoryMapper
    {
        public static List<ValueHistory> MapToValueHistory(IEnumerable<string> lines) {
            return lines.Select(line => new ValueHistory {
                HistoryEntries = line.Split(' ').Select(long.Parse).ToList()
            }).ToList();
        }
    }
}