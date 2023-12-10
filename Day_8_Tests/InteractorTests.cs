namespace Day_8_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData("TestInputData1.txt", 2);
                yield return new TestCaseData("TestInputData2.txt", 6);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_CalculateStepCountToGoal(string inputFileName, int expectedResult)
        {
            var result = Interactor.CalculateStepCountToGoal(inputFileName);
            result.Should().Be(expectedResult);
        }
    }
}