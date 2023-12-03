using System.Text.RegularExpressions;

namespace No_1
{
    public static partial class Calculator
    {
        public static int CalculateCalibrationValueSum(string[] input) {
            var result = 0;
            foreach (var item in input)
            {
                result += CalculateSingleCalibrationValue(item);
            }
            return result;
        }

        public static int CalculateSingleCalibrationValue(string input) {
            Regex regex = NoDigitsRegex();
            var numbersOnly = regex.Replace(input, string.Empty);
            var first = numbersOnly[0];
            var last = numbersOnly[^1];
            var resultAsString = $"{first}{last}";
            return int.Parse(resultAsString);
        }

        [GeneratedRegex(@"[^\d]")]
        private static partial Regex NoDigitsRegex();
    }
}