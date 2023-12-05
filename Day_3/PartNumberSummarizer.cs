namespace Day_3;

public static class PartNumberSummarizer
{
    public static int SumPartNumbers(IEnumerable<PartNumber> partNumbers) {
        return partNumbers.Sum(p => p.Value);
    }
}
