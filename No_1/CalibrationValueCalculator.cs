namespace No_1
{
    public static partial class CalibrationValueCalculator
    {
        public static int CalculateSingleCalibrationValue(string input)
        {
            var first = input[0];
            var last = input[^1];
            var resultAsString = $"{first}{last}";
            return int.Parse(resultAsString);
        }
    }
}