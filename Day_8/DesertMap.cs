namespace Day_8
{
    public class DesertMap
    {
        public List<short> DirectionInstructions { get; set; } = [];

        public IDictionary<string, List<string>> WaypointMapping { get; set; } = new Dictionary<string, List<string>>();
    }
}