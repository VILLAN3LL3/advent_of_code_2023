using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_11
{
    public class Galaxy : IComparable<Galaxy>
    {
        public Galaxy(int columnIndex, int rowIndex)
        {
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
        }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        public int CompareTo(Galaxy? other)
        {
           if(other is null) return 1;
           return string.Compare($"{RowIndex}{ColumnIndex}", $"{other.RowIndex}{other.ColumnIndex}");
        }

    }
}