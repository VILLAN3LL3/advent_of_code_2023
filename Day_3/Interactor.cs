using Shared;

namespace Day_3
{
    public static class Interactor
    {
        public static int SumAllPartNumbersInEngineSchematics(string inputDataFileName) {
            var input = InputDataLoader.LoadInputData(inputDataFileName);
            EngineSchematicCell[][] matrix = EngineSchematicMapper.MapLinesToEngineSchematicMatrix(input);
            List<int> partNumbers = PartNumberFinder.FindPartNumbers(matrix);
            return PartNumberSummarizer.SumPartNumbers(partNumbers);
        }
    }
}