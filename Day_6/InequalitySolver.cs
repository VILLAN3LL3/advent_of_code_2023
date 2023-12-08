using Shared;

namespace Day_6
{
    public static class InequalitySolver
    {
        // 0 > x^2 + px + q
        public static List<long> SolveQuadraticInequality(long p, long q)
        {
            var pDouble = Convert.ToDouble(p);
            var qDouble = Convert.ToDouble(q);
            var x1 = -(pDouble / 2D) + Math.Sqrt(pDouble / 2D * (pDouble / 2D) - qDouble);
            var x2 = -(pDouble / 2D) - Math.Sqrt(pDouble / 2D * (pDouble / 2D) - qDouble);
            var min = Math.Min(x1, x2);
            var max = Math.Max(x1, x2);
            var higherBound = (max % 1) == 0 ? (long)Math.Truncate(max * 100) / 100 - 1 : (long)Math.Truncate(max * 100) / 100;
            var lowerBound = (long)Math.Truncate(min * 100) / 100 + 1;
            return lowerBound.CreateRange(higherBound - lowerBound + 1).ToList();
        }
    }
}