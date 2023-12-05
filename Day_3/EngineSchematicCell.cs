namespace Day_3
{
    public class EngineSchematicCell
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public string? Digit { get; set; }
        public bool IsStartDigit { get; set; }
        public bool IsSymbol { get; set; }
        public bool IsAdjacentToSymbol { get; set; }
        public int? GearId { get; set; }
        public List<int> AdjacentGearIds { get; set; } = [];
    }
}