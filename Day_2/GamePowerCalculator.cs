namespace Day_2;

public static class GamePowerCalculator
{
    public static int CalculateGamePower(List<Drawing> drawings)
    {
        var bluePower = CalculatePowerOfOneColor(drawings, d => d.NumberOfBlueCubes);
        var redPower = CalculatePowerOfOneColor(drawings, d => d.NumberOfRedCubes);
        var greenPower = CalculatePowerOfOneColor(drawings, d => d.NumberOfGreenCubes);
        return bluePower * redPower * greenPower;
    }

    private static int CalculatePowerOfOneColor(List<Drawing> drawings, Func<Drawing, int> colorSelector)
    {
        return drawings.Select(colorSelector).Max();
    }
}