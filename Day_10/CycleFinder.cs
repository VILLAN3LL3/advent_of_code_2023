using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10
{
    public static class CycleFinder
    {
        public static HashSet<Node> FindCycleInGraph(Graph graph)
        {
            var visitedNodes = new HashSet<Node>();
            var stack = new Stack<Node>();
            stack.Push(graph.Nodes[graph.StartPosition.RowIndex][graph.StartPosition.ColumnIndex]);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                if (visitedNodes.Contains(node))
                {
                    if(node.Position.Equals(graph.StartPosition))
                    {
                        return visitedNodes;
                    }
                    continue;
                }

                List<Position> neighbourPositions = FindNeighbourPositions(node, graph.MaxRowIndex, graph.MaxColumnIndex, visitedNodes.LastOrDefault());
                foreach (Position neighbourPosition in neighbourPositions)
                {
                    Node neighbourNode = graph.Nodes[neighbourPosition.RowIndex][neighbourPosition.ColumnIndex];
                    if (!neighbourNode.IsGround)
                    {
                        stack.Push(neighbourNode);
                    }
                }
                visitedNodes.Add(node);
            }
            return visitedNodes;
        }

        private static List<Position> FindNeighbourPositions(Node node, int maxRowIndex, int maxColumnIndex, Node? previousNode)
        {
            var neighbourPositions = new List<Position>();
            foreach (Position neighbourConfig in Config.NeighbourPositions[node.Value])
            {
                var neighbourRowIndex = node.Position.RowIndex + neighbourConfig.RowIndex;
                var neighbourColumnIndex = node.Position.ColumnIndex + neighbourConfig.ColumnIndex;
                var neighbourPosition = new Position(neighbourRowIndex, neighbourColumnIndex);

                if (neighbourRowIndex > -1
                    && neighbourColumnIndex > -1
                    && neighbourRowIndex <= maxRowIndex
                    && neighbourColumnIndex <= maxColumnIndex
                    && (previousNode is null || !previousNode.Position.Equals(neighbourPosition)))
                {
                    neighbourPositions.Add(neighbourPosition);
                }
            }
            return neighbourPositions;
        }

    }
}