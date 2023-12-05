using Shared;

namespace Day_3
{
    public class PartNumber
    {
        public PartNumber() {}
        
        public PartNumber(int value, params int[] adjacentGearIds) {
            Value = value;
            AdjacentGearIds.AddRange(adjacentGearIds);
        }

        public int Value { get; set; }
        public HashSet<int> AdjacentGearIds { get; set; } = [];
    }
}