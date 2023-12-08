
using Shared;

namespace Day_5
{
    public static class Interactor
    {
        public static long CalculateMinimumLocation(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            Almanac almanac = AlmanacMapper.MapAlmanac(lines);
            var locations = new List<long>();
            foreach (var seed in almanac.Seeds)
            {
                locations.Add(LocationCalculator.CalculateLocation(seed, almanac.CategoryMaps));
            }
            return locations.Min();
        }
    }
}