namespace Day_3_Tests
{
    [TestFixture]
    public class GearRatioCalculatorTests
    {
        [Test]
        public void Test_CalculateGearRatioSum()
        {
            int expectedResult = 467835;

            int result = GearRatioCalculator.CalculateGearRatioSum(EngineSchematicTestData.TestSchematic, EngineSchematicTestData.TestPartNumbers);

            result.Should().Be(expectedResult);
        }
    }
}