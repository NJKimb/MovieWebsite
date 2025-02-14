using System.Threading.Tasks;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Dtos;
using MovieAPI.Entities;

namespace MovieAPI.Data;

public class MovieRepository(DataContext context, IMapper mapper) : IMovieRepository
{
    public void AddMovie(Movie movie)
    {
        context.Movies.Add(movie);
    }

    public async Task<bool> DeleteMovieByIdAsync(int id)
    {
        var movie = await context.Movies.FindAsync(id);

        if (movie == null){
            return false;
        }

        context.Movies.Remove(movie);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<Movie?> GetMovieByIdAsync(int id)
    {
        return await context.Movies.FindAsync(id);
    }

    public async Task<Movie?> GetMovieByTitleAsync(string title)
    {
        return await context.Movies
            .SingleOrDefaultAsync(x => x.Title == title);
    }

    public async Task<MovieDto?> GetMovieDtoAsync(string title)
    {
        return await context.Movies
            .Where(x => x.Title == title)
            .ProjectTo<MovieDto>(mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<Movie>> GetMoviesAsync()
    {
        return await context.Movies
            .ToListAsync();
    }

    public async Task<IEnumerable<MovieDto?>> GetMoviesDtoAsync()
    {
        return await context.Movies
            .ProjectTo<MovieDto>(mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void Update(Movie movie)
    {
        context.Entry(movie).State = EntityState.Modified;
    }
}