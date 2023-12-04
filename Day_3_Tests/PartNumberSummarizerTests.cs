﻿namespace Day_3_Tests;

[TestFixture]
public class PartNumberSummarizerTests
{
    [Test]
    public void Test_SumPartNumbers() {
        IEnumerable<int> partNumbers = EngineSchematicTestData.TestPartNumbers;

        int result = PartNumberSummarizer.SumPartNumbers(partNumbers);

        result.Should().Be(4361);
    }
}
