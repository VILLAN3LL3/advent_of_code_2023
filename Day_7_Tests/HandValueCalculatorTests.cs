namespace Day_7_Tests
{
    [TestFixture]
    public class HandValueCalculatorTests
    {
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(CamelPokerTestData.Hand1, 21110);
            yield return new TestCaseData(CamelPokerTestData.Hand2, 31100);
            yield return new TestCaseData(CamelPokerTestData.Hand3, 22100);
            yield return new TestCaseData(CamelPokerTestData.Hand4, 22100);
            yield return new TestCaseData(CamelPokerTestData.Hand5, 31100);
            yield return new TestCaseData(new Hand(0, 'A', 'A', 'A', 'A', 'A'), 50000);
            yield return new TestCaseData(new Hand(0, '2', '3', '4', '5', '6'), 11111);
            yield return new TestCaseData(new Hand(0, 'A', 'A', '3', 'A', 'A'), 41000);
            yield return new TestCaseData(new Hand(0, 'A', 'A', '3', 'A', '3'), 32000);
        }
    }

    [TestCaseSource(nameof(TestSource))]
        public void Test_CalculateHandValue(Hand hand, int expectedResult) {
            var result = HandValueCalculator.CalculateHandValue(hand);

            result.Should().Be(expectedResult);
        }
    }
}