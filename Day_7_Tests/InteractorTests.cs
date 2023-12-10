namespace Day_7_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private const string InputFileName = "TestInputData.txt";
        
        [Test]
        public void Test_CalculateTotalWinnings()
        {
            int expectedResult = 6440;

            int result = Interactor.CalculateTotalWinnings(InputFileName);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void Test_CalculateTotalWinningsWithJokers()
        {
            int expectedResult = 5905;

            int result = Interactor.CalculateTotalWinningsWithJokers(InputFileName);

            result.Should().Be(expectedResult);
        }
    }
}