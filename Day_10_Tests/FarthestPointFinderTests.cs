namespace Day_10_Tests
{
    [TestFixture]
    public class FarthestPointFinderTests
    {
        [TestCase(8, 4)]
        [TestCase(9, 5)]
        public void Test_CalculateStepsToFarthestPoint(int cycleLength, int expectedSteps) {
            var actualSteps = FarthestPointFinder.CalculateStepsToFarthestPoint(cycleLength);
            actualSteps.Should().Be(expectedSteps);
        }
    }
}