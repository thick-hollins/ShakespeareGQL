using System.Linq;
using ShakespeareGQL.Data;
using ShakespeareGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace ShakespeareGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Chapter> GetChapter([ScopedService] AppDbContext context)
        {
            return context.Chapters;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Character> GetCharacter([ScopedService] AppDbContext context)
        {
            return context.Characters;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Work> GetWork([ScopedService] AppDbContext context)
        {
            return context.Works;
        }
        
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<WordForm> GetWordForm([ScopedService] AppDbContext context)
        {
            return context.WordForms;
        }
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Paragraph> GetParagraph([ScopedService] AppDbContext context)
        {
            return context.Paragraphs;
        }

    }
}