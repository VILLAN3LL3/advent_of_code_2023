namespace Day_7_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateTotalWinnings()
        {
            int expectedResult = 6440;
            string inputFileName = "TestInputData.txt";

            int result = Interactor.CalculateTotalWinnings(inputFileName);

            result.Should().Be(expectedResult);
        }
    }
}