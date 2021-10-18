using System.Linq;
using ShakespeareGQL.Data;
using ShakespeareGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ShakespeareGQL.GraphQL
{
    public class ParagraphType : ObjectType<Paragraph>
    {
        protected override void Configure(IObjectTypeDescriptor<Paragraph> descriptor)
        {
            descriptor.Description("Represents a paragraph spoken by a character");

            descriptor
                .Field(p => p.Character)
                .ResolveWith<Resolvers>(p => p.GetCharacter(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the character who speaks these lines");

            descriptor
                .Field(p => p.Work)
                .ResolveWith<Resolvers>(p => p.GetWork(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the work to which this paragraph belongs");
        }

        private class Resolvers
        {
            public Character GetCharacter(Paragraph paragraph, [ScopedService] AppDbContext context)
            {
                return context.Characters.FirstOrDefault(c => c.CharacterId == paragraph.CharId);
            }

            public Work GetWork(Paragraph paragraph, [ScopedService] AppDbContext context)
            {
                return context.Works.FirstOrDefault(w => w.WorkId == paragraph.WorkId);
            }
        }
    }
}