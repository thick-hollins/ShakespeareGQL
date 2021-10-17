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
        public IQueryable<Chapter> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Chapters;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Character> GetCommand([ScopedService] AppDbContext context)
        {
            return context.Characters;
        }
    }
}