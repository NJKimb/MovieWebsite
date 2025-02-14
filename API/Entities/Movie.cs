using API.Entities;

namespace MovieAPI.Entities;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string PhotoUrl { get; set; }
    public required string Director { get; set; }
    public float Rating { get; set; }
    public required DateOnly ReleaseDate { get; set; } 
}
