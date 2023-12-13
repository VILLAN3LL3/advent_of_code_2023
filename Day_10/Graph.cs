using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10
{
    public class Graph
    {
        public Node[][] Nodes { get; set; } = [];

        public Position StartPosition { get; set; } = new Position(0, 0);

        public int MaxRowIndex => Nodes.Length - 1;
        public int MaxColumnIndex => Nodes[0].Length - 1;
    }
}