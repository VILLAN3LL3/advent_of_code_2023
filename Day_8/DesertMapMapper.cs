namespace Day_8
{
    public static class DesertMapMapper
    {
        public static DesertMap MapDesertMap(IEnumerable<string> lines) {
            var desertMap = new DesertMap();
            desertMap.DirectionInstructions.AddRange(lines.First().Select(instruction => instruction.Equals('L') ? (short)0 : (short)1));

            for (int i = 2; i < lines.Count(); i++)
            {
                var line = lines.ElementAt(i);
                var key = line[..3];
                var left = line[7..10];
                var right = line[12..15];
                desertMap.WaypointMapping.Add(key, [left, right]);
            }

            return desertMap;
        }
    }
}