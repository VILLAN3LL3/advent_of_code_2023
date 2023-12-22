using Shared;

namespace Day_13
{
    public static class Interactor
    {
        public static long CalculateMirrorIndexes(string inputFileName) {
            var lines = InputDataLoader.LoadInputData(inputFileName);
            
            long result = 0L;

            List<List<string>> rows = Mapper.MapRows(lines);
            rows.ForEach(row => result += SymmetryFinder.FindSymmetry(row) * 100);

            List<List<string>> columns = Mapper.MapColumns(lines);
            columns.ForEach(column => result += SymmetryFinder.FindSymmetry(column));

            return result;
        }
    }
}