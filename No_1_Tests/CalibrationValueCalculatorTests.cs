using No_1;
using FluentAssertions;

namespace No_1_Tests;

[TestFixture]
public class CalibrationValueCalculatorTests
{
    private static IEnumerable<TestCaseData> TestSource
    {
        get
        {
            yield return new TestCaseData("12", 12);
            yield return new TestCaseData("38", 38);
            yield return new TestCaseData("12345", 15);
            yield return new TestCaseData("7", 77);
        }
    }

    [TestCaseSource(nameof(TestSource))]
    public void Test_CalculateCalibrationValueSume(string input, int expectedResult)
    {
        var result = CalibrationValueCalculator.CalculateSingleCalibrationValue(input);

        result.Should().Be(expectedResult);
    }
}