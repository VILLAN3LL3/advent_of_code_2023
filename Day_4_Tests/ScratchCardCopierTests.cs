namespace Day_4_Tests;

[TestFixture]
public class ScratchCardCopierTests
{
    [Test]
    public void Test_CopyScratchCards() {
        List<ScratchCardWithCopies> scratchCardsWithCopies = ScratchCardCopier.CopyScratchCards(ScratchCardTestData.TestScratchCards);
        scratchCardsWithCopies.Should().BeEquivalentTo(ScratchCardTestData.TestScratchCardsWithCopies);
    }   
}

