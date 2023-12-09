namespace Day_7_Tests
{
    [TestFixture]
    public class WinningsCalculatorTests
    {
        [Test]
        public void Test_CalculateWinnings() {
            int expectedResult = 6440;
            IEnumerable<Hand> sortedHands = CamelPokerTestData.SortedTestHands;

            int result = WinningsCalculator.CalculateWinnings(sortedHands);

            result.Should().Be(expectedResult);
        }
    }
}