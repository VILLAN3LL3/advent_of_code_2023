using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared;

namespace Day_11
{
    public static class Interactor
    {
        public static int CalculateSumOfShortestPathsBetweenAllGalaxies(string inputFileName) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            List<Galaxy> galaxies = GalaxyFinder.FindGalaxiesInUniverse(lines);
            List<int> expandableRows = UniverseExpander.FindExpandableRows(lines);
            List<int> expandableColumns = UniverseExpander.FindExpandableColumns(lines);
            return PathLengthFinder.FindShortestPathBetweenGalaxies(galaxies, expandableRows, expandableColumns);
        }
    }
}