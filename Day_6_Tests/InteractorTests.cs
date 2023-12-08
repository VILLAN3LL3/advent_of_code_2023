namespace Day_6_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateProductOfNumberOfWaysToBeatRecord()
        {
            long result = Interactor.CalculateProductOfNumberOfWaysToBeatRecord("TestInputData.txt");

            result.Should().Be(288);
        }
    }
}