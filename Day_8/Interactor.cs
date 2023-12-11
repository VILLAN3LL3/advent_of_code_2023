using Shared;

namespace Day_8
{
    public static class Interactor
    {
        public static long CalculateStepCountToGoal(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            DesertMap desertMap = DesertMapMapper.MapDesertMap(lines);
            return DesertNavigator.NavigateThroughDesert(
                desertMap, 
                WaypointDefiner.IsStartWaypoint, 
                WaypointDefiner.isEndWaypoint,
                LeastCommonMultipleCalculator.CalculateLeastCommonMultiple);
        }

        public static long CalculateStepCountToGoalForGhosts(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            DesertMap desertMap = DesertMapMapper.MapDesertMap(lines);
            return DesertNavigator.NavigateThroughDesert(
                desertMap, 
                WaypointDefiner.IsStartWaypointForGhosts, 
                WaypointDefiner.isEndWaypointForGhosts,
                LeastCommonMultipleCalculator.CalculateLeastCommonMultiple);
        }
    }
}