using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Day_12_Tests
{
    [TestFixture]
    public class ArrangementFinderTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(new SpringGroup("???.###", 1, 1, 3), 1L);
                yield return new TestCaseData(new SpringGroup(".??..??...?##.", 1, 1, 3), 4L);
                yield return new TestCaseData(new SpringGroup("?#?#?#?#?#?#?#?", 1, 3, 1, 6), 1L);
                yield return new TestCaseData(new SpringGroup("????.#...#...", 4, 1, 1), 1L);
                yield return new TestCaseData(new SpringGroup("????.######..#####.", 1, 6, 5), 4L);
                yield return new TestCaseData(new SpringGroup("?###????????", 3, 2, 1), 10L);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_CalculatePossibleArrangementCount(SpringGroup springGroup, long expectedResult)
        {
            var result = ArrangementFinder.GetOrCalculatePossibleArrangementCount(springGroup);
            result.Should().Be(expectedResult);
        }
    }
}