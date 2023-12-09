namespace Day_7_Tests
{
    public static class CamelPokerTestData
    {
        public static IEnumerable<string> TestInputData => [
            "32T3K 765",
            "T55J5 684",
            "KK677 28",
            "KTJJT 220",
            "QQQJA 483"
        ];

        public static Hand Hand1 => new(765, '3', '2', 'T', '3', 'K');

        public static Hand Hand2 => new(684, 'T', '5', '5', 'J', '5');
        public static Hand Hand3 => new(28, 'K', 'K', '6', '7', '7');
        public static Hand Hand4 => new(220, 'K', 'T', 'J', 'J', 'T');
        public static Hand Hand5 => new(483, 'Q', 'Q', 'Q', 'J', 'A');


        public static List<Hand> TestHands => [
            Hand1,
            Hand2,
            Hand3,
            Hand4,
            Hand5
        ];

        public static List<Hand> SortedTestHands => [
            Hand1,
            Hand4,
            Hand3,
            Hand2,
            Hand5
        ];
    }
}