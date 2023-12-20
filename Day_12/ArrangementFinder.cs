namespace Day_12
{
    public static class ArrangementFinder
    {
        private static readonly Dictionary<string, long> Cache = [];

        public static long GetOrCalculatePossibleArrangementCount(SpringGroup springGroup)
        {
            if (Cache.TryGetValue(springGroup.Key, out var arrangementCount))
            {
                return arrangementCount;
            }

            arrangementCount = CalculatePossibleArrangementCount(springGroup);
            Cache[springGroup.Key] = arrangementCount;

            return arrangementCount;
        }

        private static long CalculatePossibleArrangementCount(SpringGroup springGroup)
        {
            var springs = springGroup.Springs;
            List<int> damagedSpringCounts = springGroup.DamagedSpringCounts;

            while (true)
            {
                if (IsDamagedSpringCountsEmpty(damagedSpringCounts))
                {
                    return HandleEmptyDamagedSpringCounts(springs);
                }

                if (IsSpringsEmpty(springs))
                {
                    return 0;
                }

                if (DoesSpringsStartWithDot(springs))
                {
                    springs = TrimDotsFromSprings(springs);
                    continue;
                }

                if (DoesSpringsStartWithQuestionMark(springs))
                {
                    return HandleSpringsStartingWithQuestionMark(springs, damagedSpringCounts);
                }

                if (DoesSpringsStartWithHash(springs))
                {
                    if (IsDamagedSpringCountsEmpty(damagedSpringCounts)
                     || DoesSpringsContainLessElementsThanFirstDamagedSpringCountsElement(springs, damagedSpringCounts)
                     || DoesSpringsAtIndexOfFirstDamagedSpringCountsContainDot(springs, damagedSpringCounts))
                    {
                        return 0;
                    }

                    if (IsDamagedSpringCountsLengthGreaterThanOne(damagedSpringCounts))
                    {
                        if (IsSpringLengthSmallerOrEqualThanFirstElementOfDamagedSpringCounts(springs, damagedSpringCounts)
                            || IsSpringsAtIndexOfFirstDamagedSpringCountsElementAHash(springs, damagedSpringCounts))
                        {
                            return 0;
                        }

                        springs = ReduceSpringsByFirstElementOfDamagedSpringCountsPlusOne(springs, damagedSpringCounts);

                        damagedSpringCounts = RemoveFirstItemFromDamagedSpringCounts(damagedSpringCounts);
                        continue;
                    }

                    springs = ReduceSpringsByFirstElementOfDamagedSpringCounts(springs, damagedSpringCounts);
                    damagedSpringCounts = RemoveFirstItemFromDamagedSpringCounts(damagedSpringCounts);
                    continue;
                }

                throw new ArgumentOutOfRangeException(nameof(springGroup), springGroup.Springs, "The supplied Springs Property is not valid.");
            }
        }

        private static bool DoesSpringsAtIndexOfFirstDamagedSpringCountsContainDot(string springs, List<int> damagedSpringCounts)
        {
            return springs[..damagedSpringCounts[0]].Contains(Config.DOT);
        }


        private static bool DoesSpringsContainLessElementsThanFirstDamagedSpringCountsElement(string springs, List<int> damagedSpringCounts)
        {
            return springs.Length < damagedSpringCounts[0];
        }


        private static bool IsDamagedSpringCountsLengthGreaterThanOne(List<int> damagedSpringCounts)
        {
            return damagedSpringCounts.Count > 1;
        }


        private static bool IsSpringLengthSmallerOrEqualThanFirstElementOfDamagedSpringCounts(string springs, List<int> damagedSpringCounts)
        {
            return springs.Length <= damagedSpringCounts[0];
        }

        private static bool IsSpringsAtIndexOfFirstDamagedSpringCountsElementAHash(string springs, List<int> damagedSpringCounts)
        {
            return springs[damagedSpringCounts[0]] == Config.HASH;
        }


        private static string ReduceSpringsByFirstElementOfDamagedSpringCountsPlusOne(string springs, List<int> damagedSpringCounts)
        {
            return springs[(damagedSpringCounts[0] + 1)..];
        }


        private static string ReduceSpringsByFirstElementOfDamagedSpringCounts(string springs, List<int> damagedSpringCounts)
        {
            return springs[damagedSpringCounts[0]..];
        }


        private static List<int> RemoveFirstItemFromDamagedSpringCounts(List<int> damagedSpringCounts)
        {
            return damagedSpringCounts[1..];
        }


        private static bool DoesSpringsStartWithHash(string springs)
        {
            return springs.StartsWith(Config.HASH);
        }


        private static long HandleSpringsStartingWithQuestionMark(string springs, List<int> damagedSpringCounts)
        {
            return GetOrCalculatePossibleArrangementCount(new SpringGroup($"{Config.DOT}{springs[1..]}", [.. damagedSpringCounts]))
                + GetOrCalculatePossibleArrangementCount(new SpringGroup($"{Config.HASH}{springs[1..]}", [.. damagedSpringCounts]));
        }


        private static bool DoesSpringsStartWithQuestionMark(string springs)
        {
            return springs.StartsWith(Config.QUESTION_MARK);
        }


        private static string TrimDotsFromSprings(string springs)
        {
            return springs.Trim(Config.DOT);
        }


        private static bool DoesSpringsStartWithDot(string springs)
        {
            return springs.StartsWith(Config.DOT);
        }


        private static bool IsSpringsEmpty(string springs)
        {
            return string.IsNullOrEmpty(springs);
        }


        private static long HandleEmptyDamagedSpringCounts(string springs)
        {
            return springs.Contains(Config.HASH) ? 0 : 1;
        }


        private static bool IsDamagedSpringCountsEmpty(List<int> damagedSpringCounts)
        {
            return damagedSpringCounts.Count == 0;
        }
    }
}