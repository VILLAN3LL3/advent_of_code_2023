using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_6_Tests
{
    public static class RaceTestData
    {
        public static List<string> TestInputData =>
            [
                "Time:      7  15   30",
                "Distance:  9  40  200"
            ];

        public static List<Race> TestRacesPart1 => [
            new Race {
                Duration = 7,
                RecordDistance = 9
            },
            new Race {
                Duration = 15,
                RecordDistance = 40
            },
            new Race {
                Duration = 30,
                RecordDistance = 200
            }
        ];

        public static Race TestRacePart2 => new Race 
        {
            Duration = 71530,
            RecordDistance = 940200
        };
    }
}