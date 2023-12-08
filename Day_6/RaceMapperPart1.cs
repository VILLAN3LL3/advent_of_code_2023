namespace Day_6
{
    public static class RaceMapperPart1
    {
        public static List<Race> MapRaces(IEnumerable<string> lines) {
            var races = new List<Race>();
            foreach (var line in lines)
            {
                if(line.StartsWith("Time:")) {
                    races.AddRange(line[5..].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => new Race { Duration = int.Parse(x)}));
                    continue;
                }
                if(line.StartsWith("Distance:")) {
                    IEnumerable<int> elements = line[9..].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x));
                    for (int i = 0; i < races.Count; i++)
                    {
                        races[i].RecordDistance = elements.ElementAt(i);
                    }
                }
            }
            return races;
        }
    }
}