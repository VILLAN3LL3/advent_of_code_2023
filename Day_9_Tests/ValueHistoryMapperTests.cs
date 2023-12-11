namespace Day_9_Tests
{
    [TestFixture]
    public class ValueHistoryMapperTests
    {
        [Test]
        public void Test_MapToValueHistory()
        {
            List<ValueHistory> result = ValueHistoryMapper.MapToValueHistory(ValueHistoryTestData.TestInputData);
            result.Should().BeEquivalentTo(ValueHistoryTestData.TestValueHistories);
        }
    }
}