namespace Day_10
{
    public static class EnclosedTileCounter
    {
        /*
         * Pick's theorem
        */
        public static int CountEnclosedTiles(int cycleNodesCount, int area) {
            // A - b/2 + 1
            return area - (cycleNodesCount / 2) + 1;
        }
    }
}