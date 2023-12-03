namespace Day_2;

public static class GameMapper
{
    public static Game MapLineToGame(string line)
    {
        var splittedLine = line.Split(':', StringSplitOptions.TrimEntries);

        var gamePart = splittedLine[0];
        var drawingPart = splittedLine[1];

        return new Game(MapGameId(gamePart), MapDrawings(drawingPart).ToArray());
    }

    private static int MapGameId(string gamePart)
    {
        return int.Parse(gamePart[5..]);
    }

    private static List<Drawing> MapDrawings(string drawingPart)
    {
        var drawingsAsString = drawingPart.Split(';', StringSplitOptions.TrimEntries);
        var drawings = new List<Drawing>();
        foreach (var drawingAsString in drawingsAsString)
        {
            var splittedDrawing = drawingAsString.Split(',', StringSplitOptions.TrimEntries);
            drawings.Add(new Drawing(
                GetColorCount(splittedDrawing, "red"),
                GetColorCount(splittedDrawing, "blue"),
                GetColorCount(splittedDrawing, "green")
            ));
        }

        return drawings;
    }

    private static int GetColorCount(string[] splittedDrawing, string color)
    {
        return splittedDrawing
                    .Where(item => item.Contains(color))
                    .Select(item => int.Parse(item.Split(' ')[0]))
                    .FirstOrDefault();
    }
}
