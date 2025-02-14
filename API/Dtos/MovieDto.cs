namespace MovieAPI.Dtos;

public class MovieDto
{
    public required string Title { get; set; }
    public required string PhotoUrl { get; set; }
    public required string Director { get; set; }
    public float Rating { get; set; }
    public required DateOnly ReleaseDate { get; set; }
}
