using NUnit.Framework.Internal;

namespace Day_4_Tests;

[TestFixture]
public class ScratchCardCopySummarizerTests
{
    [Test]
    public void Test_SummarizeScratchCardCopies() {
        var result = ScratchCardCopySummarizer.SummarizeScratchCardCopies(ScratchCardTestData.TestScratchCardsWithCopies);
        result.Should().Be(30);
    }
}
