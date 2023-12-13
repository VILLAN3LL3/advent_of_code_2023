using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10
{
    public static class FarthestPointFinder
    {
        public static int CalculateStepsToFarthestPoint(int cycleLength) {
            var isEven = cycleLength % 2 == 0;
            if(isEven) {
                return cycleLength / 2;
            }
            return (cycleLength - 1) / 2 + 1;
        }
    }
}