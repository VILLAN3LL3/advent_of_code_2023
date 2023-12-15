using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_11
{
    public static class UniverseExpander
    {
        public static List<int> FindExpandableRows(string[] lines)
        {
            var expandableRows = new List<int>();

            for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
            {
                var row = lines[rowIndex];
                if (!row.Contains('#'))
                {
                    expandableRows.Add(rowIndex);
                }
            }
            return expandableRows;
        }

        public static List<int> FindExpandableColumns(string[] lines)
        {
            var expandableColumns = new List<int>();
            for (int colIndex = 0; colIndex < lines[0].Length; colIndex++)
            {
                var doesGalaxiesInColumnExist = false;
                foreach (var row in lines)
                {
                    if (row[colIndex] == '#')
                    {
                        doesGalaxiesInColumnExist = true;
                        break;
                    }
                }
                if (!doesGalaxiesInColumnExist)
                {
                    expandableColumns.Add(colIndex);
                }
            }
            return expandableColumns;
        }
    }
}