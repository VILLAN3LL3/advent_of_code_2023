namespace Day_7_Tests
{
    [TestFixture]
    public class HandByHighCardComparerTests
    {

        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(new Hand(0, 'A', 'A', '3', 'A', '3'), new Hand(0, 'T', 'A', '3', 'A', '3'), -1);
                yield return new TestCaseData(new Hand(0, 'A', 'J', '3', 'A', '3'), new Hand(0, 'A', 'A', '3', 'A', '3'), 1);
                yield return new TestCaseData(new Hand(0, 'A', 'J', 'Q', 'A', '3'), new Hand(0, 'A', 'J', '3', 'A', '3'), -1);
                yield return new TestCaseData(new Hand(0, 'A', 'J', 'Q', '2', '3'), new Hand(0, 'A', 'J', 'Q', 'A', '3'), 1);
                yield return new TestCaseData(new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '3'), -1);
                yield return new TestCaseData(new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '9'), 0);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_Compare(Hand x, Hand y, int expectedResult)
        {
            var result = new HandByHighCardComparer().Compare(x, y);

            result.Should().Be(expectedResult);
        }
    }
}