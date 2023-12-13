using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Day_10
{
    public static class Config
    {
        public static IReadOnlyDictionary<char, List<Position>> NeighbourPositions => new Dictionary<char, List<Position>>
        {
            { '|', [North, South] },
            { '-', [West, East] },
            { 'L', [North, East] },
            { 'J', [North, West] },
            { '7', [South, West]},
            { 'F', [South, East]},
            { '.', []},
            { 'S', [North, South, West, East]}
        };

        private static Position West => new(0, -1);
        private static Position East => new(0, 1);
        private static Position North => new(-1, 0);
        private static Position South => new(1, 0);
    }
}