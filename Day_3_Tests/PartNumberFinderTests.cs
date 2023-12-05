namespace Day_3_Tests;

[TestFixture]
public class PartNumberFinderTests
{
    [Test]
    public void Test_FindPartNumbers() {
        IEnumerable<PartNumber> expectedResult = EngineSchematicTestData.TestPartNumbers;

        List<PartNumber> result = PartNumberFinder.FindPartNumbers(EngineSchematicTestData.TestSchematic);

        result.Should().BeEquivalentTo(expectedResult);
    }
}
