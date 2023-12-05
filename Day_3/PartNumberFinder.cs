using System.Text;
using Shared;

namespace Day_3;

public static class PartNumberFinder
{
    public static List<PartNumber> FindPartNumbers(EngineSchematic engineSchematic)
    {
        var result = new List<PartNumber>();

        if(engineSchematic.Cells is null) return result;

        EngineSchematicCell[][] cells = engineSchematic.Cells;
        
        for (int row = 0; row < cells.Length; row++)
        {
            for (int col = 0; col < cells[row].Length; col++)
            {
                EngineSchematicCell cell = cells[row][col];
                if(cell.IsStartDigit) {
                    var partNumber = new PartNumber();
                    partNumber.AdjacentGearIds.AddRange(cell.AdjacentGearIds);
                    var isPartNumber = cell.IsAdjacentToSymbol;
                    var numberStringBuilder = new StringBuilder(cell.Digit);
                    var nextCol = col + 1;
                    while (nextCol <= engineSchematic.MaxColumnIndex && cells[row][nextCol].Digit is not null)
                    {
                        EngineSchematicCell nextCell = cells[row][nextCol];
                        isPartNumber = isPartNumber || nextCell.IsAdjacentToSymbol;
                        partNumber.AdjacentGearIds.AddRange(nextCell.AdjacentGearIds);
                        numberStringBuilder.Append(nextCell.Digit);
                        nextCol++;
                    }
                    if(isPartNumber) {
                        partNumber.Value = int.Parse(numberStringBuilder.ToString());
                        result.Add(partNumber);
                    }
                }
            }
        }

        return result;
    }
}
