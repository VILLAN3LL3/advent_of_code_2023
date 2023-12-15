using Shared;

namespace Day_11
{
    public static class Interactor
    {
        public static long CalculateSumOfShortestPathsBetweenAllGalaxies(string inputFileName, int expansionFactor) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Galaxy> galaxies = GalaxyFinder.FindGalaxiesInUniverse(lines);
            List<int> expandableRows = UniverseExpander.FindExpandableRows(lines);
            List<int> expandableColumns = UniverseExpander.FindExpandableColumns(lines);
            return DistanceCalculator.CalculateShortestDistanceBetweenGalaxies(galaxies, expandableRows, expandableColumns, expansionFactor);
        }
    }
}