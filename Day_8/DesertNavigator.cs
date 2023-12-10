using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_8
{
    public static class DesertNavigator
    {
        public static int NavigateThroughDesert(DesertMap desertMap)
        {
            int direction;
            var currentWaypoint = "AAA";
            var goalWaypoint = "ZZZ";
            var visitedWaypoints = new List<string>();
            IDictionary<string, List<string>> waypointMapping = desertMap.WaypointMapping;

            while (!currentWaypoint.Equals(goalWaypoint))
            {
                List<string> waypoint = waypointMapping[currentWaypoint];
                direction = visitedWaypoints.Count >= desertMap.DirectionInstructions.Count
                    ? desertMap.DirectionInstructions[visitedWaypoints.Count % desertMap.DirectionInstructions.Count]
                    : desertMap.DirectionInstructions[visitedWaypoints.Count];
                currentWaypoint = waypoint[direction];
                visitedWaypoints.Add(currentWaypoint);
            }

            return visitedWaypoints.Count;
        }
    }
}