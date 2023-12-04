namespace Day_2_Tests;

[TestFixture]
public class GamePowerCalculatorTests
{
  private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(
                new Game(1, new Drawing(4, 3, 0), new Drawing(1, 6, 2), new Drawing(0, 0, 2)),
                48);
            yield return new TestCaseData(
                new Game(2, new Drawing(0, 1, 2), new Drawing(1, 4, 3), new Drawing(0, 1, 1)),
                12);
            yield return new TestCaseData(
                new Game(3, new Drawing(20, 6, 8), new Drawing(4, 5, 13), new Drawing(1, 0, 5)),
                1560);
            yield return new TestCaseData(
                new Game(4, new Drawing(3, 6, 1), new Drawing(6, 0, 3), new Drawing(14, 15, 0)),
                630);
            yield return new TestCaseData(
                new Game(5, new Drawing(6, 1, 3), new Drawing(1, 2, 2)),
                36);
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_IsGamePossible(Game gameToCheck, int expectedResult)
    {
        var result = GamePowerCalculator.CalculateGamePower(gameToCheck.Drawings);

        result.Should().Be(expectedResult);
    }
}
