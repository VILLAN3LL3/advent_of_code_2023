namespace Day_3_Tests;

[TestFixture]
public class PartNumberFinderTests
{
    [Test]
    public void Test_FindPartNumbers() {
        var expectedResult = EngineSchematicTestData.TestPartNumbers;

        List<int> result = PartNumberFinder.FindPartNumbers(EngineSchematicTestData.TestSchematic);

        result.Should().BeEquivalentTo(expectedResult);
    }
}
