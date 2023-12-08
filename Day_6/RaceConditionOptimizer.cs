namespace Day_6
{
    public static class RaceConditionOptimizer
    {
        public static long CalculateOptimalRaceConditions(List<Race> races, Func<long, long, List<long>> inequalitySolver)
        {

            var numberOfWaysToBeatRecord = new List<long>();
            foreach (Race race in races)
            {
                numberOfWaysToBeatRecord.Add(CalculateOptimalConditionsForSingleRace(race, inequalitySolver));
            }
            return numberOfWaysToBeatRecord.Aggregate((a, b) => a * b);
        }

        public static long CalculateOptimalConditionsForSingleRace(Race race, Func<long, long, List<long>> inequalitySolver) {
            List<long> inequalitySolutions = inequalitySolver(race.Duration * -1, race.RecordDistance);
            return inequalitySolutions.Count;
        }
    }
}