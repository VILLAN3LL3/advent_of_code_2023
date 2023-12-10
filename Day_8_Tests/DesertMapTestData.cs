using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_8_Tests
{
    public static class DesertMapTestData
    {
        public static IEnumerable<string> TestInputData => [
            "RL",
            "",
            "AAA = (BBB, CCC)",
            "BBB = (DDD, EEE)",
            "CCC = (ZZZ, GGG)",
            "DDD = (DDD, DDD)",
            "EEE = (EEE, EEE)",
            "GGG = (GGG, GGG)",
            "ZZZ = (ZZZ, ZZZ)",
        ];

        public static DesertMap TestDesertMap1 => new()
        {
            DirectionInstructions = [1, 0],
            WaypointMapping = new Dictionary<string, List<string>>
            {
                ["AAA"] = ["BBB", "CCC"],
                ["BBB"] = ["DDD", "EEE"],
                ["CCC"] = ["ZZZ", "GGG"],
                ["DDD"] = ["DDD", "DDD"],
                ["EEE"] = ["EEE", "EEE"],
                ["GGG"] = ["GGG", "GGG"],
                ["ZZZ"] = ["ZZZ", "ZZZ"],
            }
        };

        public static DesertMap TestDesertMap2 = new()
        {
            DirectionInstructions = [0, 0, 1],
            WaypointMapping = new Dictionary<string, List<string>>
            {
                ["AAA"] = ["BBB", "BBB"],
                ["BBB"] = ["AAA", "ZZZ"],
                ["ZZZ"] = ["ZZZ", "ZZZ"],
            }
        };
    }
}