using System.Reflection.Metadata;

namespace Day_2_Tests;

public class GameMapperTests
{
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData(
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 
                new Game(1, new Drawing(4, 3, 0), new Drawing(1, 6, 2), new Drawing(0,0,2)));
            yield return new TestCaseData(
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 
                new Game(2, new Drawing(0, 1, 2), new Drawing(1, 4, 3), new Drawing(0, 1, 1)));
            yield return new TestCaseData(
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                new Game(3, new Drawing(20, 6, 8), new Drawing(4, 5, 13), new Drawing(1, 0, 5)));
            yield return new TestCaseData(
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                new Game(4, new Drawing(3, 6, 1), new Drawing(6, 0, 3), new Drawing(14, 15, 0)));
            yield return new TestCaseData(
                "Game 500: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green",
                new Game(500, new Drawing(6, 1, 3), new Drawing(1, 2, 2)));
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_MapLineToGame(string line, Game expectedResult)
    {
        Game result = GameMapper.MapLineToGame(line);

        result.Should().Be(expectedResult);
    }
}