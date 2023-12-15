using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_11
{
    public static class GalaxyFinder
    {
        public static List<Galaxy> FindGalaxiesInUniverse(string[] lines)
        {
            List<Galaxy> galaxies = [];
            for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
            {
                var row = lines[rowIndex];
                for (int colIndex = 0; colIndex < row.Length; colIndex++)
                {
                    if (row[colIndex] == '#')
                    {
                        galaxies.Add(new Galaxy(colIndex, rowIndex));
                    }
                }
            }
            return galaxies;
        }
    }
}