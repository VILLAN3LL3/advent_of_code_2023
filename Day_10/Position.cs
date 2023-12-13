namespace Day_10
{
    public sealed class Position : IEquatable<Position>
    {
        public Position(int rowIndex, int columnIndex)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
        }

        public int RowIndex { get; }
        public int ColumnIndex { get; }

        public bool Equals(Position? other)
        {
            return RowIndex.Equals(other?.RowIndex) && ColumnIndex.Equals(other?.ColumnIndex);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Position);
        }

        public override int GetHashCode()
        {
            return RowIndex.GetHashCode() ^ ColumnIndex.GetHashCode();
        }
    }
}