namespace Day_1_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData("TestInputData.txt", 142);
                yield return new TestCaseData("TestInputDataWithSpelledNumbers.txt", 281);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_CalculateSumOfCalibrationValues(string inputFileName, int expectedResult)
        {
            var result = Interactor.CalculateSumOfCalibrationValues(inputFileName);
            result.Should().Be(expectedResult);
        }
    }
}