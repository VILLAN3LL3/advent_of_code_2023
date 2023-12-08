using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5_Tests
{
    [TestFixture]
    public class AlmanacMapperTests
    {
        [Test]
        public void Test_MapAlmanac() {
            Almanac result = AlmanacMapper.MapAlmanac(AlmanacTestData.TestLines);
            result.Should().BeEquivalentTo(AlmanacTestData.TestAlmanac);
        }
    }
}