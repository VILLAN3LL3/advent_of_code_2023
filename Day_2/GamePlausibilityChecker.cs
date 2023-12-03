namespace Day_2;

public static class GamePlausibilityChecker
{
    public static bool IsGamePossible(Bag bag, Game game) {
        foreach (Drawing drawing in game.Drawings)
        {
            if(drawing.NumberOfGreenCubes > bag.NumberOfGreenCubes) {
                return false;
            }
            if(drawing.NumberOfRedCubes > bag.NumberOfRedCubes) {
                return false;
            }
            if(drawing.NumberOfBlueCubes > bag.NumberOfBlueCubes) {
                return false;
            }
        }
        return true;
    }
}
