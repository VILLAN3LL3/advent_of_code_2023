namespace Day_9_Tests
{
    public static class ValueHistoryTestData
    {
        public static IEnumerable<string> TestInputData => [
            "0 3 6 9 12 15",
            "1 3 6 10 15 21",
            "10 13 16 21 30 45",
        ];

        public static ValueHistory ValueHistory1 => new ValueHistory {
            HistoryEntries = [0, 3, 6, 9, 12, 15]
        };

        public static ValueHistory ValueHistory2 => new ValueHistory {
            HistoryEntries = [1, 3, 6, 10, 15, 21]
        };

        public static ValueHistory ValueHistory3 => new ValueHistory {
            HistoryEntries = [10, 13, 16, 21, 30, 45]
        };

        public static List<ValueHistory> TestValueHistories => [
            ValueHistory1,
            ValueHistory2,
            ValueHistory3,
        ];
    }
}