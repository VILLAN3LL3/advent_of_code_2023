namespace Day_6_Tests
{
    [TestFixture]
    public class RaceMapperPart1Tests
    {
        [Test]
        public void Test_MapRaces() {
            List<Race> result = RaceMapperPart1.MapRaces(RaceTestData.TestInputData);
            result.Should().BeEquivalentTo(RaceTestData.TestRacesPart1);
        }
    }
}