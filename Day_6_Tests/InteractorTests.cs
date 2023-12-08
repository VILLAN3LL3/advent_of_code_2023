namespace Day_6_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void CalculateProductOfNumberOfWaysToBeatRecordPart1()
        {
            long result = Interactor.CalculateProductOfNumberOfWaysToBeatRecordPart1("TestInputData.txt");

            result.Should().Be(288);
        }

        [Test]
        public void CalculateProductOfNumberOfWaysToBeatRecordPart2()
        {
            long result = Interactor.CalculateProductOfNumberOfWaysToBeatRecordPart2("TestInputData.txt");

            result.Should().Be(71503);
        }
    }
}