namespace Day_9_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_SummarizeExtrapolatedNextValues() {
            var result = Interactor.SummarizeExtrapolatedNextValues("TestInputData.txt");
            result.Should().Be(114);
        }
    }
}