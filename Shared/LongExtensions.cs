namespace Shared
{
    public static class LongExtensions
    {
        public static IEnumerable<long> CreateRange(this long start, long length)
        {
            var limit = start + length;

            while (start < limit)
            {
                yield return start;
                start++;
            }
        }
    }
}