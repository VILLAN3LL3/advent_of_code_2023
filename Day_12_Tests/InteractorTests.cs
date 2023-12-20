namespace Day_12_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateSumOfAllPossibleArrangementCounts() {
            var result = Interactor.CalculateSumOfAllPossibleArrangementCounts("TestInputData.txt");
            result.Should().Be(21L);
        }

        [Test]
        public void Test_CalculateSumOfAllPossibleArrangementCounts_Given_RepeatFactor5() {
            var result = Interactor.CalculateSumOfAllPossibleArrangementCounts("TestInputData.txt", 5);
            result.Should().Be(525152L);
        }
    }
}
