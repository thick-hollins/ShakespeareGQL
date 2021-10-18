using System.Linq;
using ShakespeareGQL.Data;
using ShakespeareGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace ShakespeareGQL.GraphQL
{
    public class ChapterType : ObjectType<Chapter>
    {
        protected override void Configure(IObjectTypeDescriptor<Chapter> descriptor)
        {
            descriptor.Description("Represents a scene");

            descriptor
                .Field(ch => ch.Work)
                .ResolveWith<Resolvers>(ch => ch.GetWork(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is this work to which the chapter (act) belongs");
        }

        private class Resolvers
        {
            public Work GetWork(Chapter chapter, [ScopedService] AppDbContext context)
            {
                return context.Works.FirstOrDefault(w => w.WorkId == chapter.WorkId);
            }
        }
    }
}