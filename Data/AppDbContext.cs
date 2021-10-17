using ShakespeareGQL.Models;
using Microsoft.EntityFrameworkCore;
using ShakespeareGQL.Data.Imports;

namespace ShakespeareGQL.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
          .Entity<Chapter>()
          .HasData(Reader<ChapterImport>.Read("Chapters"));

        modelBuilder
          .Entity<Character>()
          .HasData(Reader<CharacterImport>.Read("Characters"));
    }
  }    
}