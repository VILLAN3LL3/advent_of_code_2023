using Shared;

namespace Day_6
{
    public static class Interactor
    {
        public static long CalculateProductOfNumberOfWaysToBeatRecord(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Race> races = RaceMapper.MapRaces(lines);
            return RaceConditionOptimizer.CalculateOptimalRaceConditions(races, InequalitySolver.SolveQuadraticInequality);
        }
    }
}