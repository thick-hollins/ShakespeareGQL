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
    public DbSet<Work> Works { get; set; }
    public DbSet<WordForm> WordForms { get; set; }
    public DbSet<Paragraph> Paragraphs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
          .Entity<Chapter>()
          .HasData(Reader<ChapterImport>.Read("Text/Chapters"));

        modelBuilder
          .Entity<Character>()
          .HasData(Reader<CharacterImport>.Read("Text/Characters"));

        modelBuilder
          .Entity<Work>()
          .HasData(Reader<WorkImport>.Read("Text/Works"));

        modelBuilder
          .Entity<WordForm>()
          .HasData(Reader<WordFormImport>.Read("Text/WordForms"));

        modelBuilder
          .Entity<Paragraph>()
          .HasData(Reader<ParagraphImport>.Read("Text/Paragraphs"));
    }
  }    
}