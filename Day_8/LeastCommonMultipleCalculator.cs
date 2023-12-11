namespace Day_8
{
    public static class LeastCommonMultipleCalculator
    {
        public static long CalculateLeastCommonMultiple(IEnumerable<long> numbers)
        {
            return numbers.Aggregate(CalculateLeastCommonMultipleForTwoNumbers);
        }
        public static long CalculateLeastCommonMultipleForTwoNumbers(long a, long b)
        {
            return Math.Abs(a * b) / CalculateGreatestCommonDivisor(a, b);
        }
        public static long CalculateGreatestCommonDivisor(long a, long b)
        {
            return b == 0 ? a : CalculateGreatestCommonDivisor(b, a % b);
        }
    }
}