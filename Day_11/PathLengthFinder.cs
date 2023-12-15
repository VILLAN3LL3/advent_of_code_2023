using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared;

namespace Day_11
{
    public static class PathLengthFinder
    {
        public static int FindShortestPathBetweenGalaxies(List<Galaxy> galaxies, List<int> expandableRows, List<int> expandableColumns)
        {
            int distance = 0;

            IEnumerable<Tuple<Galaxy, Galaxy>> combinations = from galaxy1 in galaxies
                               from galaxy2 in galaxies
                               where galaxy1.CompareTo(galaxy2) < 0
                               select Tuple.Create(galaxy1, galaxy2);

            foreach (Tuple<Galaxy, Galaxy> galaxyTuple in combinations)
            {
                Galaxy galaxy1 = galaxyTuple.Item1;
                Galaxy galaxy2 = galaxyTuple.Item2;
                distance += FindShortestPathBetweentwoGalaxies(galaxy1, galaxy2);
                IEnumerable<int> rowsToCheck = Enumerable.Range(Math.Min(galaxy1.RowIndex, galaxy2.RowIndex), Math.Max(galaxy1.RowIndex, galaxy2.RowIndex) - Math.Min(galaxy1.RowIndex, galaxy2.RowIndex));
                foreach (var _ in from int row in rowsToCheck
                                  where expandableRows.Contains(row)
                                  select new { })
                {
                    distance += 1;
                }

                IEnumerable<int> columnsToCheck = Enumerable.Range(Math.Min(galaxy1.ColumnIndex, galaxy2.ColumnIndex), Math.Max(galaxy1.ColumnIndex, galaxy2.ColumnIndex) - Math.Min(galaxy1.ColumnIndex, galaxy2.ColumnIndex));
                foreach (var _ in from int col in columnsToCheck
                                  where expandableColumns.Contains(col)
                                  select new { })
                {
                    distance += 1;
                }
            }

            return distance;
        }

        public static int FindShortestPathBetweentwoGalaxies(Galaxy galaxy1, Galaxy galaxy2)
        {
            return Math.Abs(galaxy1.RowIndex - galaxy2.RowIndex) + Math.Abs(galaxy1.ColumnIndex - galaxy2.ColumnIndex);
        }
    }
}