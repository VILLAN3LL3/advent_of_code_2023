using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_13_Tests
{
    [TestFixture]
    public class MapperTests
    {
        private static readonly List<string> lines = [
            "#.##..##.",
            "..#.##.#.",
            "##......#",
            "##......#",
            "..#.##.#.",
            "..##..##.",
            "#.#.##.#.",
            "",
            "#...##..#",
            "#....#..#",
            "..##..###",
            "#####.##.",
            "#####.##.",
            "..##..###",
            "#....#..#"
        ];
        
        [Test]
        public void Test_MapRows() {
            
            var expected = new List<List<string>> {
                new() {
                    "#.##..##.",
                    "..#.##.#.",
                    "##......#",
                    "##......#",
                    "..#.##.#.",
                    "..##..##.",
                    "#.#.##.#.",
                },
                new() {
                    "#...##..#",
                    "#....#..#",
                    "..##..###",
                    "#####.##.",
                    "#####.##.",
                    "..##..###",
                    "#....#..#",
                }
            };

            List<List<string>> result = Mapper.MapRows(lines);

            result.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Test_MapColumns() {
            var expected = new List<List<string>> {
                new() {
                    "#.##..#",
                    "..##...",
                    "##..###",
                    "#....#.",
                    ".#..#.#",
                    ".#..#.#",
                    "#....#.", 
                    "##..###",
                    "..##...",
                },
                new() {
                    "##.##.#",
                    "...##..",
                    "..####.",
                    "..####.",
                    "#..##..",
                    "##....#",
                    "..####.",
                    "..####.",
                    "###..##",
                }
            };

            List<List<string>> result = Mapper.MapColumns(lines);

            result.Should().BeEquivalentTo(expected);
        }
    }
}