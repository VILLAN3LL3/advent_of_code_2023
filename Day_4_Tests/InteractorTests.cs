namespace Day_4_Tests;

[TestFixture]
public class InteractorTests
{
    [Test]
    public void Test_CalculateTotalValueOfScratchCards() {
        int result = Interactor.CalculateTotalValueOfScratchCards("TestInputData.txt");
        result.Should().Be(13);
    }

    [Test]
    public void Test_CalculateTotalScratchCardCount() {
        int result = Interactor.CalculateTotalScratchCardCount("TestInputData.txt");
        result.Should().Be(30);
    }
}
