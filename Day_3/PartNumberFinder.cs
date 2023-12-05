using System.Text;

namespace Day_3;

public static class PartNumberFinder
{
    public static List<int> FindPartNumbers(EngineSchematic engineSchematic)
    {
        var result = new List<int>();
        EngineSchematicCell[][] cells = engineSchematic.Cells;
        
        for (int row = 0; row < cells.Length; row++)
        {
            for (int col = 0; col < cells[row].Length; col++)
            {
                EngineSchematicCell cell = cells[row][col];
                if(cell.IsStartDigit) {
                    var isPartNumber = cell.IsAdjacentToSymbol;
                    var numberStringBuilder = new StringBuilder(cell.Digit);
                    var nextCol = col + 1;
                    while (nextCol <= engineSchematic.MaxColumnIndex && cells[row][nextCol].Digit is not null)
                    {
                        EngineSchematicCell nextCell = cells[row][nextCol];
                        isPartNumber = isPartNumber || nextCell.IsAdjacentToSymbol;
                        numberStringBuilder.Append(nextCell.Digit);
                        nextCol++;
                    }
                    if(isPartNumber) {
                        result.Add(int.Parse(numberStringBuilder.ToString()));
                    }
                }
            }
        }

        return result;
    }
}
