namespace Day_12
{
    public static class SpringGroupMapper
    {
        public static List<SpringGroup> MapToSpringGroups(IEnumerable<string> lines, int repeatFactor = 1) {
            var springGroups = new List<SpringGroup>();

            foreach (var line in lines)
            {
                SpringGroup springGroup = MapToSpringGroup(line, repeatFactor);
                springGroups.Add(springGroup);
            }

            return springGroups;
        }

        private static SpringGroup MapToSpringGroup(string line, int repeatFactor)
        {
            var splittedLine = line.Split(" ");
            var springs = splittedLine[0];
            IEnumerable<int> damagedSpringCounts = splittedLine[1].Split(",").Select(int.Parse);

            if(repeatFactor > 1) {
                springs = string.Join(Config.QUESTION_MARK, Enumerable.Repeat(springs, repeatFactor));
                damagedSpringCounts = Enumerable.Repeat(damagedSpringCounts, repeatFactor).SelectMany(g => g);
            }

            return new SpringGroup(springs, damagedSpringCounts.ToArray());
        }
    }
}