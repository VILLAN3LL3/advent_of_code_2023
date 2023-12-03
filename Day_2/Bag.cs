namespace Day_2;

public class Bag
{
    public int NumberOfRedCubes { get; set; }
    public int NumberOfBlueCubes { get; set; }
    public int NumberOfGreenCubes { get; set; }

    public Bag(int numberOfRedCubes, int numberOfBlueCubes, int numberOfGreenCubes)
    {
        NumberOfBlueCubes = numberOfBlueCubes;
        NumberOfGreenCubes = numberOfGreenCubes;
        NumberOfRedCubes = numberOfRedCubes;
    }
}
