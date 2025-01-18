using Microsoft.EntityFrameworkCore;
using MovieAPI.Entities;

namespace MovieAPI.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
}
