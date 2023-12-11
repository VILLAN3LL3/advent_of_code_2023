using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_9_Tests
{
    [TestFixture]
    public class ValueHistoryExtrapolatorTests
    {
        private static IEnumerable<TestCaseData> TestSourceNext
        {
            get
            {
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory1, 18);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory2, 28);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory3, 68);
            }
        }

        [TestCaseSource(nameof(TestSourceNext))]
        public void ExtrapolateNextHistoryEntry(ValueHistory valueHistory, long expectedResult) {
            var input = new List<List<long>> { valueHistory.HistoryEntries };
            var result = ValueHistoryExtrapolator.ExtrapolateHistoryEntry(input, false);
            result.Should().Be(expectedResult);
        }

        private static IEnumerable<TestCaseData> TestSourcePrevious
        {
            get
            {
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory1, -3);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory2, 0);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory3, 5);
            }
        }

        [TestCaseSource(nameof(TestSourcePrevious))]
        public void ExtrapolatePreviousHistoryEntry(ValueHistory valueHistory, long expectedResult) {
            var input = new List<List<long>> { valueHistory.HistoryEntries };
            var result = ValueHistoryExtrapolator.ExtrapolateHistoryEntry(input, true);
            result.Should().Be(expectedResult);
        }
    }
}