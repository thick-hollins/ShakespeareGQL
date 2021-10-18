using System.Linq;
using ShakespeareGQL.Data;
using ShakespeareGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ShakespeareGQL.GraphQL
{
    public class WorkType : ObjectType<Work>
    {
        protected override void Configure(IObjectTypeDescriptor<Work> descriptor)
        {
            descriptor.Description("Represents a play or other work");

            descriptor
                .Field(w => w.Chapters)
                .ResolveWith<Resolvers>(w => w.GetChapters(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is this the list of chapters in the work");
        }

        private class Resolvers
        {
            public IQueryable<Chapter> GetChapters(Work work, [ScopedService] AppDbContext context)
            {
                return context.Chapters.Where(ch => ch.WorkId == work.WorkId);
            }
        }
    }
}