namespace No_1
{
    public static class Interactor
    {
        public static int Interact(string inputFileName) {
            var input = InputLoader.LoadInput(inputFileName);

            var result = 0;
            foreach (var item in input)
            {
                var stringWithDigitsOnly = NumberExtractor.ExtractAllNumbersFromString(item);
                result += CalibrationValueCalculator.CalculateSingleCalibrationValue(stringWithDigitsOnly);

            }
            return result;
        }
    }
}