namespace Day_10_Tests
{
    [TestFixture]
    public class CycleFinderTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(GraphTestData.Graph1, 8);
                yield return new TestCaseData(GraphTestData.Graph2, 16);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_FindCycleInGraph(Graph graph, int expectedCycleLength) {
            HashSet<Node> result = CycleFinder.FindCycleInGraph(graph);
            result.Count.Should().Be(expectedCycleLength);
        }
    }
}