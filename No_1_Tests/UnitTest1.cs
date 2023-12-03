using No_1;
using FluentAssertions;
using NUnit.Framework;

namespace No_1_Tests;

[TestFixture]
public class Tests
{
    private Calculator calculator = new Calculator();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Gesamttest()
    {
        var input = new[] {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet"
       };

        var result = calculator.Calculate(input);

        result.Should().Be(142);
    }

    private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData("1abc2", 12);
                yield return new TestCaseData("pqr3stu8vwx", 38);
                yield return new TestCaseData("a1b2c3d4e5f", 15);
                yield return new TestCaseData("treb7uchet", 77);
            }
        }

    [TestCaseSource(nameof(TestSource))]
    public void Einzeltest(string input, int expectedResult) {
        var result = calculator.CalculateSingle(input);

        result.Should().Be(expectedResult);
    }
}