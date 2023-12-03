namespace Day_2;

public sealed class Game : IEquatable<Game>
{
    public List<Drawing> Drawings { get; set; } = [];
    public int Id { get; set; }

    public Game(int id, params Drawing[] drawings) {
        Id = id;
        Drawings.AddRange(drawings);
    }

    public bool Equals(Game? other)
    {
        if(other is null) {
            return false;
        }
        if(other.Id != Id) {
            return false;
        }
        if(other.Drawings.Count != Drawings.Count) {
            return false;
        }
        for (int i = 0; i < Drawings.Count - 1; i++)
        {
            if(!Drawings[i].Equals(other.Drawings[i])) {
                return false;
            }
        }
        return true;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Game);
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
