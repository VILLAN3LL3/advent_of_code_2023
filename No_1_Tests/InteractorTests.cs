namespace No_1_Tests
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
        public void Test_Interact(string inputFileName, int expectedResult) {
            var result = Interactor.Interact(inputFileName);
            result.Should().Be(expectedResult);
        }
    }
}