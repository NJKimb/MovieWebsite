using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;
using MovieAPI.Dtos;
using MovieAPI.Entities;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController(IMovieRepository movieRepository, IMapper mapper) : ControllerBase
    {

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            var movies = await movieRepository.GetMoviesAsync();

            return Ok(movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await movieRepository.GetMovieByIdAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("add")]
        public async Task<ActionResult<Movie>> PostMovie(MovieDto MovieDto)
        {
            Movie movie = new Movie
            {
                Title = MovieDto.Title,
                Director = MovieDto.Director,
                ReleaseDate = MovieDto.ReleaseDate,
                Rating = MovieDto.Rating,
                PhotoUrl = MovieDto.PhotoUrl
            };

            movieRepository.AddMovie(movie);
            await movieRepository.SaveAllAsync();

            return Ok();
        }

        // DELETE: api/Movies/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await movieRepository.DeleteMovieByIdAsync(id);
            return NoContent();
        }
    }
}
