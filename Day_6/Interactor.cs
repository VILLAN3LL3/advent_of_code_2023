using Shared;

namespace Day_6
{
    public static class Interactor
    {
        public static long CalculateProductOfNumberOfWaysToBeatRecordPart1(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Race> races = RaceMapperPart1.MapRaces(lines);
            return RaceConditionOptimizer.CalculateOptimalRaceConditions(races, InequalitySolver.SolveQuadraticInequality);
        }

        public static long CalculateProductOfNumberOfWaysToBeatRecordPart2(string inputFileName) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            Race race = RaceMapperPart2.MapRace(lines);
            return RaceConditionOptimizer.CalculateOptimalConditionsForSingleRace(race, InequalitySolver.SolveQuadraticInequality);
        }
    }
}