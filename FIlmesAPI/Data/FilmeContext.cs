using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FIlmesAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions opts) : base(opts)
    {
    }

    public DbSet<Filme> Filmes { get; set; }
}
