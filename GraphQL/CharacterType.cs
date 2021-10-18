using System.Linq;
using ShakespeareGQL.Data;
using ShakespeareGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ShakespeareGQL.GraphQL
{
    public class CharacterType : ObjectType<Character>
    {
        protected override void Configure(IObjectTypeDescriptor<Character> descriptor)
        {
            descriptor.Description("Represents a character");

            descriptor
                .Field(c => c.Paragraphs)
                .ResolveWith<Resolvers>(c => c.GetParagraphs(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is this the list of paragraphs which this character speaks");
        }

        private class Resolvers
        {
            public IQueryable<Paragraph> GetParagraphs(Character character, [ScopedService] AppDbContext context)
            {
                return context.Paragraphs.Where(p => p.CharId == character.CharacterId);
            }
        }
    }
}