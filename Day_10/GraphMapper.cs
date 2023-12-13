using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10
{
    public static class GraphMapper
    {
        public static Graph MapGraph(string[] lines)
        {
            var nodes = new Node[lines.Length][];
            var startPosition = new Position(0, 0);
            for (int rowIndex = 0; rowIndex < lines.Length; rowIndex++)
            {
                nodes[rowIndex] = new Node[lines[rowIndex].Length];
                for (int columnIndex = 0; columnIndex < lines[rowIndex].Length; columnIndex++)
                {
                    var value = lines[rowIndex][columnIndex];
                    if (value == 'S')
                    {
                        startPosition = new Position(rowIndex, columnIndex);
                    }
                    var node = new Node(value, rowIndex, columnIndex);
                    nodes[rowIndex][columnIndex] = node;

                }
            }
            return new Graph { Nodes = nodes, StartPosition = startPosition };
        }
    }
}