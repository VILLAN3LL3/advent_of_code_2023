namespace Day_5
{
    public static class LocationCalculator
    {
        public static List<long> CalculateLocations(Seed seed, List<CategoryMap> categoryMaps)
        {
            var locations = new List<long>();
            for (long i = seed.SeedRangeStart; i < seed.SeedRangeStart + seed.SeedRangeLength; i++)
            {
                locations.Add(CalculationLocation(i, categoryMaps));
            }
            return locations;
        }

        private static long CalculationLocation(long singleSeed, List<CategoryMap> categoryMaps)
        {
            long result = singleSeed;
            foreach (CategoryMap categoryMap in categoryMaps.OrderBy(x => x.SortOrder))
            {
                foreach (CategoryRange range in categoryMap.Ranges.OrderBy(c => c.SourceRangeStart))
                {
                    if (result >= range.SourceRangeStart && result < range.SourceRangeStart + range.RangeLength)
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