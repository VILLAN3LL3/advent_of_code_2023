using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_6_Tests
{
    [TestFixture]
    public class RaceMapperTests
    {
        [Test]
        public void Test_MapRaces() {
            List<Race> result = RaceMapper.MapRaces(RaceTestData.TestInputData);
            result.Should().BeEquivalentTo(RaceTestData.TestRaces);
        }
    }
}