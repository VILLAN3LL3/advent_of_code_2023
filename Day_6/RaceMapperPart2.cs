namespace Day_6
{
    public static class RaceMapperPart2
    {
        public static Race MapRace(IEnumerable<string> lines) {
            var race = new Race();
            foreach (var line in lines)
            {
                if(line.StartsWith("Time:")) {
                    race.Duration = long.Parse(line[5..].Replace(" ", ""));
                    continue;
                }
                if(line.StartsWith("Distance:")) {
                    race.RecordDistance = long.Parse(line[9..].Replace(" ", ""));
                }
            }
            return race;
        }
    }
}