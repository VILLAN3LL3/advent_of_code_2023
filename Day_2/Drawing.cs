namespace Day_2;

public sealed class Drawing : IEquatable<Drawing>
{
    public int NumberOfRedCubes { get; set; }
    public int NumberOfBlueCubes { get; set; }
    public int NumberOfGreenCubes { get; set; }

    public Drawing(int numberOfRedCubes, int numberOfBlueCubes, int numberOfGreenCubes)
    {
        NumberOfBlueCubes = numberOfBlueCubes;
        NumberOfGreenCubes = numberOfGreenCubes;
        NumberOfRedCubes = numberOfRedCubes;
    }

    public bool Equals(Drawing? other)
    {
        if (other is null)
        {
            return false;
        }
        return NumberOfBlueCubes == other.NumberOfBlueCubes
        && NumberOfGreenCubes.Equals(other.NumberOfGreenCubes)
        && NumberOfRedCubes.Equals(other.NumberOfRedCubes);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Drawing);
    }

    public override int GetHashCode()
    {
        return NumberOfBlueCubes.GetHashCode() + NumberOfGreenCubes.GetHashCode() + NumberOfRedCubes.GetHashCode();
    }
}
