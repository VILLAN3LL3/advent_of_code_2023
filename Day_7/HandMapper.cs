namespace Day_7
{
    public static class HandMapper
    {
        public static List<Hand> MapHands(IEnumerable<string> lines) => lines.Select(MapStringToHand).ToList();

        private static Hand MapStringToHand(string line)
        {
            var splittedLine = line.Split(' ', StringSplitOptions.TrimEntries);
            return new Hand(int.Parse(splittedLine[1]), splittedLine[0].ToCharArray());
        }
    }
}