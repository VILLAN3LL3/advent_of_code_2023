namespace Day_3_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_SumAllPartNumbersInEngineSchematics() {
            var result = Interactor.SumAllPartNumbersInEngineSchematics("TestInputData.txt");

            result.Should().Be(4361);
        }
    }
}