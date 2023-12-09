using System.Collections.Immutable;

namespace Day_7
{
    public static class Config
    {
        public static IImmutableDictionary<char, int> CardValueDictionary => ImmutableSortedDictionary.CreateRange(new List<KeyValuePair<char, int>> {
            new('2', 2),
            new('3', 3),
            new('4', 4),
            new('5', 5),
            new('6', 6),
            new('7', 7),
            new('8', 8),
            new('9', 9),
            new('T', 10),
            new('J', 11),
            new('Q', 12),
            new('K', 13),
            new('A', 14)
        });

        public enum HandType
        {
            HighCard, // 1-1-1-1-1
            OnePair, // 2-1-1-1-0
            TwoPairs, // 2-2-1-0-0
            ThreeOfAKind, // 3-1-1-0-0
            FullHouse, // 3-2-0-0-0
            FourOfAKind, // 4-1-0-0-0
            FiveOfAKind, // 5-0-0-0-0
        }
    }
}