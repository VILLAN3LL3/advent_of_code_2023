namespace Day_5_Tests
{
    [TestFixture]
    public class LocationCalculatorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(79, 82);
                yield return new TestCaseData(14, 43);
                yield return new TestCaseData(55, 86);
                yield return new TestCaseData(13, 35);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_CalculateLocation(int seed, int expectedResult) {
            var result = LocationCalculator.CalculateLocation(seed, AlmanacTestData.TestAlmanac.CategoryMaps);
            result.Should().Be(expectedResult);
        }
    }
}