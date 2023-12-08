using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_6_Tests
{
    [TestFixture]
    public class InequalitySolverTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(-7, 9, new List<int> { 2, 3, 4, 5 });
                yield return new TestCaseData(-15, 40, new List<int> { 4, 5, 6, 7, 8, 9, 10, 11 });
                yield return new TestCaseData(-30, 200, new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19 });
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_SolveQuadraticInequality(int p, int q, List<int> expectedResult)
        {
            List<int> result = InequalitySolver.SolveQuadraticInequality(p, q);

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}