namespace Day_2_Tests;

[TestFixture]
public class GamePlausibilityCheckerTests
{
    private static Bag Bag = new(12, 14, 13);
    
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(
                new Game(1, new Drawing(4, 3, 0), new Drawing(1, 6, 2), new Drawing(0, 0, 2)),
                true);
            yield return new TestCaseData(
                new Game(2, new Drawing(0, 1, 2), new Drawing(1, 4, 3), new Drawing(0, 1, 1)),
                true);
            yield return new TestCaseData(
                new Game(3, new Drawing(20, 6, 8), new Drawing(4, 5, 13), new Drawing(1, 0, 5)),
                false);
            yield return new TestCaseData(
                new Game(4, new Drawing(3, 6, 1), new Drawing(6, 0, 3), new Drawing(14, 15, 0)),
                false);
            yield return new TestCaseData(
                new Game(500, new Drawing(6, 1, 3), new Drawing(1, 2, 2)),
                true);
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_IsGamePossible(Game gameToCheck, bool expectedResult)
    {
        var result = GamePlausibilityChecker.IsGamePossible(Bag, gameToCheck);

        result.Should().Be(expectedResult);
    }
}
