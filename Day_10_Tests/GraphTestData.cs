using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10_Tests
{
    public static class GraphTestData
    {
        public static string[] TestInputData1 = [
            "-L|F7",
            "7S-7|",
            "L|7||",
            "-L-J|",
            "L|-JF"
        ];

        public static Graph Graph1 = new Graph
        {
            Nodes = new Node[][]
            {
                new Node[] { new Node('-', 0, 0), new Node('L', 0, 1), new Node('|', 0, 2), new Node('F', 0, 3), new Node('7', 0, 4) },
                new Node[] { new Node('7', 1, 0), new Node('S', 1, 1), new Node('-', 1, 2), new Node('7', 1, 3), new Node('|', 1, 4) },
                new Node[] { new Node('L', 2, 0), new Node('|', 2, 1), new Node('7', 2, 2), new Node('|', 2, 3), new Node('|', 2, 4) },
                new Node[] { new Node('-', 3, 0), new Node('L', 3, 1), new Node('-', 3, 2), new Node('J', 3, 3), new Node('|', 3, 4) },
                new Node[] { new Node('L', 4, 0), new Node('|', 4, 1), new Node('-', 4, 2), new Node('J', 4, 3), new Node('F', 4, 4) }
            },
            StartPosition = new Position(1, 1)
        };

        public static string[] TestInputData2 = [
            "7-F7-",
            ".FJ|7",
            "SJLL7",
            "|F--J",
            "LJ.LJ"
        ];

        public static Graph Graph2 = new Graph
        {
            Nodes = new Node[][]
            {
                new Node[] { new Node('7', 0, 0), new Node('-', 0, 1), new Node('F', 0, 2), new Node('7', 0, 3), new Node('-', 0, 4) },
                new Node[] { new Node('.', 1, 0), new Node('F', 1, 1), new Node('J', 1, 2), new Node('|', 1, 3), new Node('7', 1, 4) },
                new Node[] { new Node('S', 2, 0), new Node('J', 2, 1), new Node('L', 2, 2), new Node('L', 2, 3), new Node('7', 2, 4) },
                new Node[] { new Node('|', 3, 0), new Node('F', 3, 1), new Node('-', 3, 2), new Node('-', 3, 3), new Node('J', 3, 4) },
                new Node[] { new Node('L', 4, 0), new Node('J', 4, 1), new Node('.', 4, 2), new Node('L', 4, 3), new Node('J', 4, 4) }
            },
            StartPosition = new Position(2, 0)
        };
    }
}