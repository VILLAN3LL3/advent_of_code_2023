namespace Day_7_Tests
{
    [TestFixture]
    public class PokerHandSorterTests
    {
        [Test]
        public void Test_SortHands([Values(true, false)]bool withJoker)
        {
            List<Hand> expectedResult = withJoker ? CamelPokerTestData.SortedTestHandsWithJokers : CamelPokerTestData.SortedTestHands;

            IEnumerable<Hand> result = PokerHandSorter.SortHands(
                CamelPokerTestData.TestHands,
                withJoker ? TypeValueCalculatorWithJokers.CalculateTypeValue : TypeValueCalculator.CalculateTypeValue,
                withJoker ? Config.CardValueDictionaryWithJoker : Config.CardValueDictionary);

            result.Should().BeEquivalentTo(expectedResult, opt => opt.WithStrictOrdering());
        }
    }
}