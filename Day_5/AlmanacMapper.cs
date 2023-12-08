namespace Day_5
{
    public static class AlmanacMapper
    {
        public static Almanac MapAlmanac(IEnumerable<string> lines) {
            var almanac = new Almanac();
            var categoryIndex = 0;
            foreach (var line in lines) {
                if (line.StartsWith("seeds:")) {
                    almanac.Seeds.AddRange(line[7..].Split(' ', StringSplitOptions.TrimEntries).Select(x => long.Parse(x)));
                } else if (line.EndsWith("map:")) {
                    var categoryMap = new CategoryMap();
                    categoryIndex++;
                    categoryMap.SortOrder = categoryIndex;
                    categoryMap.CategoryName = line.Split(' ', StringSplitOptions.TrimEntries)[0].Replace('-', ' ');
                    almanac.CategoryMaps.Add(categoryMap);
                } else if (line.Length > 0 && Char.IsDigit(line[0])) {
                    CategoryMap categoryMap = almanac.CategoryMaps.Last();
                    var split = line.Split(' ', StringSplitOptions.TrimEntries);
                    categoryMap.Ranges.Add(new CategoryRange {
                        DestinationRangeStart = long.Parse(split[0]),
                        SourceRangeStart = long.Parse(split[1]),
                        RangeLength = long.Parse(split[2])
                    });
                }
            }
            return almanac;
        }
    }
}