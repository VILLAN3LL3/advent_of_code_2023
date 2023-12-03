using Shared;

namespace Day_1
{
    public static class Interactor
    {
        public static int CalculateSumOfCalibrationValues(string inputFileName)
        {
            var input = InputDataLoader.LoadInputData(inputFileName);

            var result = 0;
            foreach (var line in input)
            {
                var stringWithDigitsOnly = NumberExtractor.ExtractAllNumbersFromString(line);
                result += CalibrationValueCalculator.CalculateSingleCalibrationValue(stringWithDigitsOnly);

            }
            return result;
        }
    }
}