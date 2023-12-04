using System.Text.RegularExpressions;

namespace Day_3
{
    public static partial class EngineSchematicMapper
    {
        [GeneratedRegex(@"\d+")]
        private static partial Regex DigitRegex();

        [GeneratedRegex(@"[^0-9.]")]
        private static partial Regex SymbolRegex();

        public static EngineSchematicCell[][] MapLinesToEngineSchematicMatrix(IEnumerable<string> lines)
        {
            EngineSchematicCell[][] matrix = lines
                .Select((row, rowIndex) => row
                    .ToCharArray()
                    .Select((character, columnIndex) => new EngineSchematicCell
                    {
                        RowIndex = rowIndex,
                        Digit = DigitRegex().IsMatch(character.ToString()) ? character.ToString() : null,
                        ColumnIndex = columnIndex,
                        IsSymbol = SymbolRegex().IsMatch(character.ToString())
                    })
                    .ToArray())
                .ToArray();

            var maxColIndex = matrix[0].Length - 1;
            var maxRowIndex = matrix.Length - 1;

            EnrichMatrixWithAdditionalInformation(matrix, maxColIndex, maxRowIndex);

            return matrix;
        }

        private static void EnrichMatrixWithAdditionalInformation(EngineSchematicCell[][] matrix, int maxColIndex, int maxRowIndex)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    EngineSchematicCell cell = matrix[row][col];
                    if (cell.Digit is not null)
                    {
                        cell.IsStartDigit = col == 0 || matrix[row][col - 1].Digit is null;
                        cell.IsAdjacentToSymbol =
                            col > 0 && matrix[row][col - 1].IsSymbol
                            || col < maxColIndex && matrix[row][col + 1].IsSymbol
                            || row > 0 && matrix[row - 1][col].IsSymbol
                            || row < maxRowIndex && matrix[row + 1][col].IsSymbol
                            || col > 0 && row > 0 && matrix[row - 1][col - 1].IsSymbol
                            || col < maxColIndex && row > 0 && matrix[row - 1][col + 1].IsSymbol
                            || col > 0 && row < maxRowIndex && matrix[row + 1][col - 1].IsSymbol
                            || col < maxColIndex && row < maxRowIndex && matrix[row + 1][col + 1].IsSymbol;

                    }
                }
            }
        }
    }
}