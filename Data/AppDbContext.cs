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

    public DbSet<Platform> Platforms { get; set; }
    public DbSet<Command> Commands { get; set; }
    public DbSet<Chapter> Chapters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder
        .Entity<Platform>()
        .HasMany(p => p.Commands)
        .WithOne(p => p.Platform!)
        .HasForeignKey(p => p.PlatformId);

        modelBuilder
          .Entity<Command>()
          .HasOne(p => p.Platform)
          .WithMany(p => p.Commands)
          .HasForeignKey(p => p.PlatformId);

        modelBuilder
          .Entity<Chapter>()
          .HasData(Reader<ChapterImport>.Read("Chapters"));

        modelBuilder
          .Entity<Character>()
          .HasData(Reader<CharacterImport>.Read("Characters"));
    }
  }    
}