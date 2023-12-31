using System;
using Shared;

namespace Day_10
{
    public static class Interactor
    {
        public static int FindFarthestPointFromStartinPointInPipeline(string inputFileName) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            Graph graph = GraphMapper.MapGraph(lines);
            HashSet<Node> cycleNodes = CycleFinder.FindCycleInGraph(graph);
            return FarthestPointFinder.CalculateStepsToFarthestPoint(cycleNodes.Count);
        }

        public static int FindEnclosedTileCount(string inputFileName) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            Graph graph = GraphMapper.MapGraph(lines);
            HashSet<Node> cycleNodes = CycleFinder.FindCycleInGraph(graph);
            var area = CycleAreaCalculator.CalculateCycleArea(cycleNodes);
            return EnclosedTileCounter.CountEnclosedTiles(cycleNodes.Count, area);
        }
    }
}