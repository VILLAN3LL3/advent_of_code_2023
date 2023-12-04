using System.Text;

namespace Day_3;

public static class PartNumberFinder
{
    public static List<int> FindPartNumbers(EngineSchematicCell[][] engineSchematicMatrix)
    {
        var result = new List<int>();
        var maxColIndex = engineSchematicMatrix[0].Length - 1;
        
        for (int row = 0; row < engineSchematicMatrix.Length; row++)
        {
            for (int col = 0; col < engineSchematicMatrix[row].Length; col++)
            {
                EngineSchematicCell cell = engineSchematicMatrix[row][col];
                if(cell.IsStartDigit) {
                    var isPartNumber = cell.IsAdjacentToSymbol;
                    var numberStringBuilder = new StringBuilder(cell.Digit);
                    var nextCol = col + 1;
                    while (nextCol <= maxColIndex && engineSchematicMatrix[row][nextCol].Digit is not null)
                    {
                        EngineSchematicCell nextCell = engineSchematicMatrix[row][nextCol];
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
