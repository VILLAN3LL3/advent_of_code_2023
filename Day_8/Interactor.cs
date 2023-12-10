using Shared;

namespace Day_8
{
    public static class Interactor
    {
        public static int CalculateStepCountToGoal(string inputFileName)
        {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            DesertMap desertMap = DesertMapMapper.MapDesertMap(lines);
            return DesertNavigator.NavigateThroughDesert(desertMap);
        }
    }
}