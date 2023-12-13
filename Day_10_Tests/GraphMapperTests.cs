namespace Day_10_Tests
{
    [TestFixture]
    public class GraphMapperTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(GraphTestData.TestInputData1, GraphTestData.Graph1);
                yield return new TestCaseData(GraphTestData.TestInputData2, GraphTestData.Graph2);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_MapGraph(IEnumerable<string> input, Graph expectedResult)
        {
            Graph result = GraphMapper.MapGraph(input.ToArray());
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}