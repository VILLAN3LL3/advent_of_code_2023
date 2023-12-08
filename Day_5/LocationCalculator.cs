namespace Day_5
{
    public static class LocationCalculator
    {
        public static long CalculateLocation(long seed, List<CategoryMap> categoryMaps) {
            var result = seed;
            foreach (CategoryMap categoryMap in categoryMaps.OrderBy(x => x.SortOrder))
            {
                foreach (CategoryRange range in categoryMap.Ranges.OrderBy(c => c.SourceRangeStart))
                {
                    if(result >= range.SourceRangeStart && result < range.SourceRangeStart + range.RangeLength)
                    {
                        result = range.SourceRangeStart > range.DestinationRangeStart ?
                            result - (range.SourceRangeStart - range.DestinationRangeStart) :
                            range.DestinationRangeStart - range.SourceRangeStart + result;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
// Seed 14, 
// soil 14, 
// fertilizer 53, water 49, light 42, temperature 42, humidity 43, location 43.