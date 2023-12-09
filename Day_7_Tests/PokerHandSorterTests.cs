namespace Day_7_Tests
{
    [TestFixture]
    public class PokerHandSorterTests
    {
        [Test]
        public void Test_SortHands()
        {
            List<Hand> expectedResult = CamelPokerTestData.SortedTestHands;

            IEnumerable<Hand> result = PokerHandSorter.SortHands(CamelPokerTestData.TestHands);

            result.Should().BeEquivalentTo(expectedResult, opt => opt.WithStrictOrdering());
        }
    }
}