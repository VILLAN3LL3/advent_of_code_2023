namespace Day_8_Tests
{
    [TestFixture]
    public class DesertNavigatorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(DesertMapTestData.TestDesertMap1, 2);
                yield return new TestCaseData(DesertMapTestData.TestDesertMap2, 6);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_NavigateThroughDesert(DesertMap desertMap, int expectedResult)
        {
            var result = DesertNavigator.NavigateThroughDesert(desertMap);
            result.Should().Be(expectedResult);
        }
    }
}