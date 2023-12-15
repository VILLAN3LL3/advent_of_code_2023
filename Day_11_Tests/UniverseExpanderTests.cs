namespace Day_11_Tests;

[TestFixture]
public class UniverseExpanderTests
{
    [Test]
    public void Test_FindExpandableColumns()
    {
        string[] lines = [
            "...#......",
            ".......#..",
            "#.........",
            "..........",
            "......#...",
            ".#........",
            ".........#",
            "..........",
            ".......#..",
            "#...#....."
        ];
        var expectedResult = new List<int> { 2, 5, 8 };

        List<int> result = UniverseExpander.FindExpandableColumns(lines);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Test_FindExpandableRows()
    {
        string[] lines = [
            "...#......",
            ".......#..",
            "#.........",
            "..........",
            "......#...",
            ".#........",
            ".........#",
            "..........",
            ".......#..",
            "#...#....."
        ];
        var expectedResult = new List<int> { 3, 7 };

        List<int> result = UniverseExpander.FindExpandableRows(lines);

        result.Should().BeEquivalentTo(expectedResult);
    }
}
