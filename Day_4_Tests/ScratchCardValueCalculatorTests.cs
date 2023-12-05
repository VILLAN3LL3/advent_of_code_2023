namespace Day_4_Tests;

[TestFixture]
public class ScratchCardValueCalculatorTests
{
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(ScratchCardTestData.ScratchCard1, 8);
            yield return new TestCaseData(ScratchCardTestData.ScratchCard2, 2);
            yield return new TestCaseData(ScratchCardTestData.ScratchCard3, 2);
            yield return new TestCaseData(ScratchCardTestData.ScratchCard4, 1);
            yield return new TestCaseData(ScratchCardTestData.ScratchCard5, 0);
            yield return new TestCaseData(ScratchCardTestData.ScratchCard6, 0);
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_CalculateScratchCardValue(ScratchCard input, int expectedResult) {
        int result = ScratchCardValueCalculator.CalculateScratchCardValue(input);
        result.Should().Be(expectedResult);
    }
}
