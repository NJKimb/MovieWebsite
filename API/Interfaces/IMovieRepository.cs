using MovieAPI.Dtos;
using MovieAPI.Entities;

namespace API.Interfaces;

public interface IMovieRepository
{
    void Update(Movie movie);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<Movie>> GetMoviesAsync();
    Task<Movie?> GetMovieByIdAsync(int id);
    Task<Movie?> GetMovieByTitleAsync(string title);
    Task<IEnumerable<MovieDto?>> GetMoviesDtoAsync();
    Task<MovieDto?> GetMovieDtoAsync(string title);
    void AddMovie(Movie movie);
    Task<bool> DeleteMovieByIdAsync(int id);
}
