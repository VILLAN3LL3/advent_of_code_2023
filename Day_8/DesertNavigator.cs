namespace Day_8
{
    public static class DesertNavigator
    {
        private static long NavigateThroughDesertForOneWaypoint(DesertMap desertMap, string startWaypoint, Func<string, bool> isEndWaypoint)
        {
            int direction;
            var currentWaypoint = startWaypoint;
            long visitedWaypointsCount = 0;
            IDictionary<string, List<string>> waypointMapping = desertMap.WaypointMapping;

            while (!isEndWaypoint(currentWaypoint))
            {
                List<string> waypoint = waypointMapping[currentWaypoint];
                direction = visitedWaypointsCount >= desertMap.DirectionInstructions.Count
                    ? desertMap.DirectionInstructions[(int)(visitedWaypointsCount % desertMap.DirectionInstructions.Count)]
                    : desertMap.DirectionInstructions[(int)visitedWaypointsCount];
                currentWaypoint = waypoint[direction];
                visitedWaypointsCount++;
            }

            return visitedWaypointsCount;
        }
        
        
        public static long NavigateThroughDesert(
            DesertMap desertMap, 
            Func<string, bool> isStartWaypoint, 
            Func<string, bool> isEndWaypoint,
            Func<IEnumerable<long>, long> aggregate)
        {
            IDictionary<string, List<string>> waypointMapping = desertMap.WaypointMapping;
            IEnumerable<string> currentWaypoints = waypointMapping.Keys.Where(isStartWaypoint);

            ParallelQuery<long> visitedWaypointsCount = currentWaypoints
                .AsParallel()
                .Select(waypoint => NavigateThroughDesertForOneWaypoint(desertMap, waypoint, isEndWaypoint));
            
            return aggregate(visitedWaypointsCount);
        }
    }
}