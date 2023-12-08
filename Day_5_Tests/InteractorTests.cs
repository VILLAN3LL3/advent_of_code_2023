namespace Day_5_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_CalculateMinimumLocation()
        {
            var expected = new List<string>
            {
                "Starting calculating minimum location for a total of 2 seeds",
                "Starting calculating minimum locations for seed 79 to 92",
                "Finished calculating minimum locations for seed 79 to 92",
                "Starting calculating minimum locations for seed 55 to 67",
                "Finished calculating minimum locations for seed 55 to 67",
                "Finished calculating minimum location for all seeds. Result: 46"
            };
            IEnumerable<string> result = Interactor.CalculateMinimumLocation("TestInputData.txt");
            result.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
        }
    }
}