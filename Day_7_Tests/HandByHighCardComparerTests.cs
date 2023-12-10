namespace Day_7_Tests
{
    [TestFixture]
    public class HandByHighCardComparerTests
    {

        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(false, new Hand(0, 'A', 'A', '3', 'A', '3'), new Hand(0, 'T', 'A', '3', 'A', '3'), 1);
                yield return new TestCaseData(false, new Hand(0, 'A', 'J', '3', 'A', '3'), new Hand(0, 'A', 'A', '3', 'A', '3'), -1);
                yield return new TestCaseData(false, new Hand(0, 'A', 'J', 'Q', 'A', '3'), new Hand(0, 'A', 'J', '3', 'A', '3'), 1);
                yield return new TestCaseData(false, new Hand(0, 'A', 'J', 'Q', '2', '3'), new Hand(0, 'A', 'J', 'Q', 'A', '3'), -1);
                yield return new TestCaseData(false, new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '3'), 1);
                yield return new TestCaseData(false, new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '9'), 0);
                yield return new TestCaseData(true, new Hand(0, 'A', 'A', '3', 'A', '3'), new Hand(0, 'T', 'A', '3', 'A', '3'), 1);
                yield return new TestCaseData(true, new Hand(0, 'A', 'J', '3', 'A', '3'), new Hand(0, 'A', 'T', '3', 'A', '3'), -1);
                yield return new TestCaseData(true, new Hand(0, 'A', 'J', 'Q', 'A', '3'), new Hand(0, 'A', 'J', '3', 'A', '3'), 1);
                yield return new TestCaseData(true, new Hand(0, 'A', 'J', 'Q', '2', '3'), new Hand(0, 'A', 'J', 'Q', 'A', '3'), -1);
                yield return new TestCaseData(true, new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '3'), 1);
                yield return new TestCaseData(true, new Hand(0, 'A', 'J', 'Q', '2', '9'), new Hand(0, 'A', 'J', 'Q', '2', '9'), 0);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_Compare(bool withJoker, Hand x, Hand y, int expectedResult)
        {
            var result = new HandByHighCardComparer(withJoker ? Config.CardValueDictionaryWithJoker : Config.CardValueDictionary).Compare(x, y);

            result.Should().Be(expectedResult);
        }
    }
}