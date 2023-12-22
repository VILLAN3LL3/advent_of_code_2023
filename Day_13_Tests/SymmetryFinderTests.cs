namespace Day_13_Tests
{
    public class SymmetryFinderTests
    {
        private static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                yield return new TestCaseData(new List<string>() {
                    "#.##..##.",
                    "..#.##.#.",
                    "##......#",
                    "##......#",
                    "..#.##.#.",
                    "..##..##.",
                    "#.#.##.#.",
                }, 0);
                yield return new TestCaseData(new List<string>() {
                    "#...##..#",
                    "#....#..#",
                    "..##..###",
                    "#####.##.",
                    "#####.##.",
                    "..##..###",
                    "#....#..#",
                }, 4);
                yield return new TestCaseData(new List<string>() {
                    "#.##..#",
                    "..##...",
                    "##..###",
                    "#....#.",
                    ".#..#.#",
                    ".#..#.#",
                    "#....#.", 
                    "##..###",
                    "..##...",
                }, 5);
                yield return new TestCaseData(new List<string>() {
                    "##.##.#",
                    "...##..",
                    "..####.",
                    "..####.",
                    "#..##..",
                    "##....#",
                    "..####.",
                    "..####.",
                    "###..##",
                }, 0);
            }
        }

        [TestCaseSource(nameof(TestSource))]
        public void Test_FindSymmetry(List<string> input, int expectedResult)
        {
            var result = SymmetryFinder.FindSymmetry(input);

            result.Should().Be(expectedResult);
        }
    }
}