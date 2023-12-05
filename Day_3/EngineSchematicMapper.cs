using System.Text.RegularExpressions;

namespace Day_3
{
    public static partial class EngineSchematicMapper
    {
        [GeneratedRegex(@"\d+")]
        private static partial Regex DigitRegex();

        [GeneratedRegex(@"[^0-9.]")]
        private static partial Regex SymbolRegex();

        [GeneratedRegex(@"\*")]
        private static partial Regex GearRegex();

        public static EngineSchematic MapLinesToEngineSchematicMatrix(IEnumerable<string> lines)
        {
            var gearId = 0;
            EngineSchematicCell[][] cells = lines
                .Select((row, rowIndex) => row
                    .ToCharArray()
                    .Select((character, columnIndex) => new EngineSchematicCell
                    {
                        RowIndex = rowIndex,
                        Digit = DigitRegex().IsMatch(character.ToString()) ? character.ToString() : null,
                        ColumnIndex = columnIndex,
                        IsSymbol = SymbolRegex().IsMatch(character.ToString()),
                        GearId = GearRegex().IsMatch(character.ToString()) ? gearId++ : null
                    })
                    .ToArray())
                .ToArray();

            var maxColIndex = cells[0].Length - 1;
            var maxRowIndex = cells.Length - 1;

            EnrichMatrixWithAdditionalInformation(cells, maxColIndex, maxRowIndex);

            return new EngineSchematic { Cells = cells, MaxColumnIndex = maxColIndex, MaxRowIndex = maxRowIndex, GearCount = gearId };
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

                        EngineSchematicCell? leftCell = col > 0 ? matrix[row][col - 1] : null;
                        EngineSchematicCell? rightCell = col < maxColIndex ? matrix[row][col + 1] : null;
                        EngineSchematicCell? upperCell = row > 0 ? matrix[row - 1][col] : null;
                        EngineSchematicCell? lowerCell = row < maxRowIndex ? matrix[row + 1][col] : null;
                        EngineSchematicCell? upperLeftCell = col > 0 && row > 0 ? matrix[row - 1][col - 1] : null;
                        EngineSchematicCell? upperRightCell = col < maxColIndex && row > 0 ? matrix[row - 1][col + 1] : null;
                        EngineSchematicCell? lowerLeftCell = col > 0 && row < maxRowIndex ? matrix[row + 1][col - 1] : null;
                        EngineSchematicCell? lowerRightCell = col < maxColIndex && row < maxRowIndex ? matrix[row + 1][col + 1] : null;

                        cell.IsAdjacentToSymbol =
                            (leftCell?.IsSymbol ?? false)
                            || (rightCell?.IsSymbol ?? false)
                            || (upperCell?.IsSymbol ?? false)
                            || (lowerCell?.IsSymbol ?? false)
                            || (upperLeftCell?.IsSymbol ?? false)
                            || (upperRightCell?.IsSymbol ?? false)
                            || (lowerLeftCell?.IsSymbol ?? false)
                            || (lowerRightCell?.IsSymbol ?? false);
                        
                        if (leftCell?.GearId is not null) cell.AdjacentGearIds.Add(leftCell.GearId.Value);
                        if (rightCell?.GearId is not null) cell.AdjacentGearIds.Add(rightCell.GearId.Value);
                        if (upperCell?.GearId is not null) cell.AdjacentGearIds.Add(upperCell.GearId.Value);
                        if (lowerCell?.GearId is not null) cell.AdjacentGearIds.Add(lowerCell.GearId.Value);
                        if (upperLeftCell?.GearId is not null) cell.AdjacentGearIds.Add(upperLeftCell.GearId.Value);
                        if (upperRightCell?.GearId is not null) cell.AdjacentGearIds.Add(upperRightCell.GearId.Value);
                        if (lowerLeftCell?.GearId is not null) cell.AdjacentGearIds.Add(lowerLeftCell.GearId.Value);
                        if (lowerRightCell?.GearId is not null) cell.AdjacentGearIds.Add(lowerRightCell.GearId.Value);
                    }
                }
            }
        }
    }
}