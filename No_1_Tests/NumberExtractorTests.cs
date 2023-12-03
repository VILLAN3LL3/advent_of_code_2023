namespace No_1_Tests
{
    [TestFixture]
    public class NumberExtractorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData("1abc2", "12");
                yield return new TestCaseData("pqr3stu8vwx", "38");
                yield return new TestCaseData("a1b2c3d4e5f", "12345");
                yield return new TestCaseData("treb7uchet", "7");
                yield return new TestCaseData("two1nine", "219");
                yield return new TestCaseData("eightwothree", "823");
                yield return new TestCaseData("abcone2threexyz", "123");
                yield return new TestCaseData("xtwone3four", "2134");
                yield return new TestCaseData("4nineeightseven2", "49872");
                yield return new TestCaseData("zoneight234", "18234");
                yield return new TestCaseData("xtwone3four", "2134");
                yield return new TestCaseData("7pqrstsixteen", "76");
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_ExtractAllNumbersFromString(string input, string expectedResult)
        {
            var result = NumberExtractor.ExtractAllNumbersFromString(input);

            result.Should().Be(expectedResult);
        }
    }
}
