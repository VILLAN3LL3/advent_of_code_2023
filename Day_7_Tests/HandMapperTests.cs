namespace Day_7_Tests
{
    [TestFixture]
    public class HandMapperTests
    {
        [Test]
        public void Test_MapHands() {
            List<Hand> result = HandMapper.MapHands(CamelPokerTestData.TestInputData);
            result.Should().BeEquivalentTo(CamelPokerTestData.TestHands);
        }
    }
}