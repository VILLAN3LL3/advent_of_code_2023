namespace Day_4_Tests;

[TestFixture]
public class ScratchCardMapperTests
{
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine1, ScratchCardTestData.ScratchCard1);
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine2, ScratchCardTestData.ScratchCard2);
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine3, ScratchCardTestData.ScratchCard3);
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine4, ScratchCardTestData.ScratchCard4);
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine5, ScratchCardTestData.ScratchCard5);
            yield return new TestCaseData(ScratchCardTestData.ScratchCardInputLine6, ScratchCardTestData.ScratchCard6);
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_MapScratchCards(string input, ScratchCard expectedResult) {
        ScratchCard result = ScratchCardMapper.MapScratchCard(input);
        result.Should().Be(expectedResult);
    }
}
