using Shared;

namespace Day_3
{
    public static class Interactor
    {
        public static int SumAllPartNumbersInEngineSchematics(string inputDataFileName) {
            var input = InputDataLoader.LoadInputData(inputDataFileName);
            EngineSchematic schematic = EngineSchematicMapper.MapLinesToEngineSchematicMatrix(input);
            List<int> partNumbers = PartNumberFinder.FindPartNumbers(schematic);
            return PartNumberSummarizer.SumPartNumbers(partNumbers);
        }
    }
}