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

        [Test]
        public void Test_SummarizeExtrapolatedPreviousValues() {
            var result = Interactor.SummarizeExtrapolatedPreviousValues("TestInputData.txt");
            result.Should().Be(2);
        }
    }
}