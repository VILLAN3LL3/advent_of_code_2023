namespace Day_13_Tests
{
    [TestFixture]
    public class InteractorTests
    {
        [Test]
        public void Test_Interact() {
            var result = Interactor.CalculateMirrorIndexes("TestInputData.txt");
            result.Should().Be(405);
        }
    }
}