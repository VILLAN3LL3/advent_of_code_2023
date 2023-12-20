using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_12_Tests
{
    [TestFixture]
    public class SpringGroupMapperTests
    {
        [Test]
        public void Test_MapToSpringGroups() {
            string[] lines = [
                "???.### 1,1,3",
                ".??..??...?##. 1,1,3",
                "?#?#?#?#?#?#?#? 1,3,1,6",
                "????.#...#... 4,1,1",
                "????.######..#####. 1,6,5",
                "?###???????? 3,2,1"
            ];
            List<SpringGroup> expectedResult = [
                new SpringGroup("???.###", 1, 1, 3),
                new SpringGroup(".??..??...?##.", 1, 1, 3),
                new SpringGroup("?#?#?#?#?#?#?#?", 1, 3, 1, 6),
                new SpringGroup("????.#...#...", 4, 1, 1),
                new SpringGroup("????.######..#####.", 1, 6, 5),
                new SpringGroup("?###????????", 3, 2, 1)
            ];

            List<SpringGroup> result = SpringGroupMapper.MapToSpringGroups(lines);

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}