using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_8
{
    public static class WaypointDefiner
    {
        public static bool IsStartWaypoint(string waypoint)
        {
            return waypoint.Equals("AAA");
        }

        public static bool isEndWaypoint(string waypoint)
        {
            return waypoint.Equals("ZZZ");
        }

        public static bool IsStartWaypointForGhosts(string waypoint)
        {
            return waypoint.EndsWith('A');
        }   

        public static bool isEndWaypointForGhosts(string waypoint)
        {
            return waypoint.EndsWith('Z');
        }
    }
}