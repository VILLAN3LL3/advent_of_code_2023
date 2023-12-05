using Shared;

namespace Day_3
{
    public static class Interactor
    {
        public static int SumAllPartNumbersInEngineSchematics(string inputDataFileName) {
            var input = InputDataLoader.LoadInputData(inputDataFileName);
            EngineSchematic schematic = EngineSchematicMapper.MapLinesToEngineSchematicMatrix(input);
            List<PartNumber> partNumbers = PartNumberFinder.FindPartNumbers(schematic);
            return PartNumberSummarizer.SumPartNumbers(partNumbers);
        }

        public static int SumAllGearRatiosInEngineSchematics(string inputDataFileName) {
            var input = InputDataLoader.LoadInputData(inputDataFileName);
            EngineSchematic schematic = EngineSchematicMapper.MapLinesToEngineSchematicMatrix(input);
            List<PartNumber> partNumbers = PartNumberFinder.FindPartNumbers(schematic);
            return GearRatioCalculator.CalculateGearRatioSum(schematic, partNumbers);
        }
    }
}