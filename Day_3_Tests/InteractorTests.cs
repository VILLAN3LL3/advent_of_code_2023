namespace Day_3_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        private const string InputDataFileName = "TestInputData.txt";


        [Test]
        public void Test_SumAllPartNumbersInEngineSchematics() {
            var result = Interactor.SumAllPartNumbersInEngineSchematics(InputDataFileName);

            result.Should().Be(4361);
        }

        [Test]
        public void Test_SumAllGearRatiosInEngineSchematics() {
            var result = Interactor.SumAllGearRatiosInEngineSchematics(InputDataFileName);

            result.Should().Be(467835);
        }
    }
}