namespace Day_5_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateMinimumLocation() {
            var result = Interactor.CalculateMinimumLocation("TestInputData.txt");
            result.Should().Be(35);
        }
    }
}