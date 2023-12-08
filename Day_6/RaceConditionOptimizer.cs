namespace Day_6
{
    public static class RaceConditionOptimizer
    {
        public static long CalculateOptimalRaceConditions(List<Race> races, Func<int, int, List<int>> inequalitySolver)
        {

            var numberOfWaysToBeatRecord = new List<long>();
            foreach (Race race in races)
            {
                List<int> inequalitySolutions = inequalitySolver(race.Duration * -1, race.RecordDistance);
                numberOfWaysToBeatRecord.Add(inequalitySolutions.Count);
            }
            return numberOfWaysToBeatRecord.Aggregate((a, b) => a * b);
        }
    }
}