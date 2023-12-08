using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5_Tests
{
    public class AlmanacTestData
    {
        public static Almanac TestAlmanac => new Almanac() {
            Seeds = [
                79,
                14,
                55,
                13
            ],
            CategoryMaps = [
                new CategoryMap() {
                    SortOrder = 1,
                    CategoryName = "seed to soil",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 50,
                            SourceRangeStart = 98,
                            RangeLength = 2
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 52,
                            SourceRangeStart = 50,
                            RangeLength = 48
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 2,
                    CategoryName = "soil to fertilizer",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 0,
                            SourceRangeStart = 15,
                            RangeLength = 37
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 37,
                            SourceRangeStart = 52,
                            RangeLength = 2
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 39,
                            SourceRangeStart = 0,
                            RangeLength = 15
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 3,
                    CategoryName = "fertilizer to water",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 49,
                            SourceRangeStart = 53,
                            RangeLength = 8
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 0,
                            SourceRangeStart = 11,
                            RangeLength = 42
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 42,
                            SourceRangeStart = 0,
                            RangeLength = 7
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 57,
                            SourceRangeStart = 7,
                            RangeLength = 4
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 4,
                    CategoryName = "water to light",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 88,
                            SourceRangeStart = 18,
                            RangeLength = 7
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 18,
                            SourceRangeStart = 25,
                            RangeLength = 70
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 5,
                    CategoryName = "light to temperature",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 45,
                            SourceRangeStart = 77,
                            RangeLength = 23
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 81,
                            SourceRangeStart = 45,
                            RangeLength = 19
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 68,
                            SourceRangeStart = 64,
                            RangeLength = 13
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 6,
                    CategoryName = "temperature to humidity",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 0,
                            SourceRangeStart = 69,
                            RangeLength = 1
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 1,
                            SourceRangeStart = 0,
                            RangeLength = 69
                        }
                    ]
                },
                new CategoryMap() {
                    SortOrder = 7,
                    CategoryName = "humidity to location",
                    Ranges = [
                        new CategoryRange() {
                            DestinationRangeStart = 60,
                            SourceRangeStart = 56,
                            RangeLength = 37
                        },
                        new CategoryRange() {
                            DestinationRangeStart = 56,
                            SourceRangeStart = 93,
                            RangeLength = 4
                        }
                    ]
                }
            ]
        };
        
        public static IEnumerable<string> TestLines => [
            "seeds: 79 14 55 13",
            "",
            "seed-to-soil map:",
            "50 98 2",
            "52 50 48",
            "",
            "soil-to-fertilizer map:",
            "0 15 37",
            "37 52 2",
            "39 0 15",
            "",
            "fertilizer-to-water map:",
            "49 53 8",
            "0 11 42",
            "42 0 7",
            "57 7 4",
            "",
            "water-to-light map:",
            "88 18 7",
            "18 25 70",
            "",
            "light-to-temperature map:",
            "45 77 23",
            "81 45 19",
            "68 64 13",
            "",
            "temperature-to-humidity map:",
            "0 69 1",
            "1 0 69",
            "",
            "humidity-to-location map:",
            "60 56 37",
            "56 93 4"
        ];
    }
}