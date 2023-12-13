namespace Day_10
{
    public static class CycleAreaCalculator
    {
        /*
         * Shoelace formula
         */
        public static int CalculateCycleArea(HashSet<Node> nodes)
        {
            var result = 0;

            for (int i = 0; i < nodes.Count; i++)
            {
                if (i == nodes.Count - 1)
                {
                    result += (nodes.ElementAt(i).Position.RowIndex + nodes.ElementAt(0).Position.RowIndex) * (nodes.ElementAt(i).Position.ColumnIndex - nodes.ElementAt(0).Position.ColumnIndex);
                }
                else
                {
                    result += (nodes.ElementAt(i).Position.RowIndex + nodes.ElementAt(i + 1).Position.RowIndex) * (nodes.ElementAt(i).Position.ColumnIndex - nodes.ElementAt(i + 1).Position.ColumnIndex);
                }
            }
            return Math.Abs(result / 2);
        }
    }
}