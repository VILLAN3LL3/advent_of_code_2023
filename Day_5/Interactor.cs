
using Shared;

namespace Day_5
{
    public static class Interactor
    {
        public static IEnumerable<string> CalculateMinimumLocation(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            Almanac almanac = AlmanacMapper.MapAlmanac(lines);
            var locations = new List<long>();
            yield return $"Starting calculating minimum location for a total of {almanac.Seeds.Count} seeds";
            foreach (Seed seed in almanac.Seeds)
            {
                yield return $"Starting calculating minimum locations for seed {seed.SeedRangeStart} to {seed.SeedRangeStart + seed.SeedRangeLength - 1}";
                locations.AddRange(LocationCalculator.CalculateLocations(seed, almanac.CategoryMaps));
                yield return $"Finished calculating minimum locations for seed {seed.SeedRangeStart} to {seed.SeedRangeStart + seed.SeedRangeLength - 1}";
            }
            yield return $"Finished calculating minimum location for all seeds. Result: {locations.Min()}";
        }
    }
}