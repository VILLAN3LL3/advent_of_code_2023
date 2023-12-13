namespace Day_10_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private static IEnumerable<TestCaseData> TestSource1
        {
            get
            {
                yield return new TestCaseData("TestInputData1.txt", 4);
                yield return new TestCaseData("TestInputData2.txt", 8);
            }
        }

        [TestCaseSource(nameof(TestSource1))]
        public void Test_FindFarthestPointFromStartinPointInPipeline(string inputFileName, int expectedSteps)
        {
            int result = Interactor.FindFarthestPointFromStartinPointInPipeline(inputFileName);
            result.Should().Be(expectedSteps);
        }

        private static IEnumerable<TestCaseData> TestSource2
        {
            get
            {
                yield return new TestCaseData("TestInputData3.txt", 8);
                yield return new TestCaseData("TestInputData4.txt", 4);
            }
        }

        [TestCaseSource(nameof(TestSource2))]
        public void Test_FindEnclosedTileCount(string inputFileName, int expectedSteps)
        {
            int result = Interactor.FindEnclosedTileCount(inputFileName);
            result.Should().Be(expectedSteps);
        }
    }
}