namespace Day_6_Tests
{
    [TestFixture]
    public class RaceMapperPart2Tests
    {
        [Test]
        public void Test_MapRace() {
            List<Race> result = RaceMapperPart1.MapRaces(RaceTestData.TestInputData);
            result.Should().BeEquivalentTo(RaceTestData.TestRacesPart1);
        }
    }
}