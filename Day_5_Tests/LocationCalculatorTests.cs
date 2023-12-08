namespace Day_5_Tests
{
    [TestFixture]
    public class LocationCalculatorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(AlmanacTestData.Seed1, new List<long> { 82L, 83L, 84L, 46L, 47L, 48L, 49L, 50L, 51L, 52L, 53L, 54L, 55L, 60L });
                yield return new TestCaseData(AlmanacTestData.Seed2, new List<long> { 86L, 87L, 88L, 89L, 94L, 95L, 96L, 56L, 57L, 58L, 59L, 97L, 98L });
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_CalculateLocation(Seed seed, List<long> expectedResult)
        {
            List<long> result = LocationCalculator.CalculateLocations(seed, AlmanacTestData.TestAlmanac.CategoryMaps);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}