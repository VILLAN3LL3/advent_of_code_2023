using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_9_Tests
{
    [TestFixture]
    public class ValueHistoryExtrapolatorTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory1, 18);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory2, 28);
                yield return new TestCaseData(ValueHistoryTestData.ValueHistory3, 68);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void ExtrapolateNextHistoryEntry(ValueHistory valueHistory, long expectedResult) {
            var input = new List<List<long>> { valueHistory.HistoryEntries };
            var result = ValueHistoryExtrapolator.ExtrapolateNextHistoryEntry(input);
            result.Should().Be(expectedResult);
        }
    }
}