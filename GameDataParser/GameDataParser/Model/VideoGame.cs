public class VideoGame
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public override string ToString() =>
        $"{Title}, released in {ReleaseYear}, ratring {Rating}";
}