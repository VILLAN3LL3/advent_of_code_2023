using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_12
{
    public static class ArrangementCountSummarizer
    {
        public static long SummarizeArrangementCounts(List<SpringGroup> springGroups, Func<SpringGroup, long> arrangementCountCalculator)
        {
            long sum = 0;

            foreach (SpringGroup springGroup in springGroups)
            {
                sum += arrangementCountCalculator(springGroup);
            }

            return sum;
        }
    }
}