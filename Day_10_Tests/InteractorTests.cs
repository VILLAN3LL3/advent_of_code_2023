namespace Day_10_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData("TestInputData1.txt", 4);
                yield return new TestCaseData("TestInputData2.txt", 8);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_FindFarthestPointFromStartinPointInPipeline(string inputFileName, int expectedSteps)
        {
            int result = Interactor.FindFarthestPointFromStartinPointInPipeline(inputFileName);
            result.Should().Be(expectedSteps);
        }
    }
}