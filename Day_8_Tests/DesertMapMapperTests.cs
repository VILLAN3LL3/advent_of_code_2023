namespace Day_8_Tests
{
    [TestFixture]
    public class DesertMapMapperTests
    {
        [Test]
        public void Test_MapDesertMap() {
            DesertMap result = DesertMapMapper.MapDesertMap(DesertMapTestData.TestInputData);

            result.Should().BeEquivalentTo(DesertMapTestData.TestDesertMap1, opt => opt.WithStrictOrdering());
        }
    }
}