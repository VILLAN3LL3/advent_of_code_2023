namespace Day_3_Tests
{
    [TestFixture]
    public class EngineSchematicMapperTests
    {
        [Test]
        public void Test_MapLinesToEngineSchematicMatrix()
        {
            var lines = new List<string> {
                "467..114..",
                "...*......",
                "..35..633.",
                "......#...",
                "617*......",
                ".....+.58.",
                "..592.....",
                "......755.",
                "...$.*....",
                ".664.598..",
            };

            EngineSchematic expected = EngineSchematicTestData.TestSchematic;

            EngineSchematic result = EngineSchematicMapper.MapLinesToEngineSchematicMatrix(lines);

            result.Should().BeEquivalentTo(expected);
        }

    }
}