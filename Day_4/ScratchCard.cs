namespace Day_4;

public class ScratchCard : IEquatable<ScratchCard>
{
    public List<int> WinningNumbers { get; set; } = [];
    public List<int> UserNumbers { get; set; } = [];
    public int CardId { get; set; }

    public bool Equals(ScratchCard? other)
    {
        if(other is null) return false;

        if(ReferenceEquals(this, other)) return true;

        return CardId.Equals(other.CardId) && WinningNumbers.SequenceEqual(other.WinningNumbers) && UserNumbers.SequenceEqual(other.UserNumbers);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as ScratchCard);
    }

    public override int GetHashCode()
    {
        return CardId.GetHashCode() ^ WinningNumbers.GetHashCode() ^ UserNumbers.GetHashCode();
    }
}
