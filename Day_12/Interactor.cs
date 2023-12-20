using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared;

namespace Day_12
{
    public static class Interactor
    {
        public static long CalculateSumOfAllPossibleArrangementCounts(string inputDataFileName, int repeatFactor = 1) {
            var lines = InputDataLoader.LoadInputData(inputDataFileName);
            List<SpringGroup> springGroups = SpringGroupMapper.MapToSpringGroups(lines, repeatFactor);
            return ArrangementCountSummarizer.SummarizeArrangementCounts(springGroups, ArrangementFinder.GetOrCalculatePossibleArrangementCount);
        }
    }
}
