using ShakespeareGQL.Data;
using ShakespeareGQL.GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace gql
{
    public class Startup
    {
    private readonly IConfiguration Configuration;

    private readonly string AllowedOrigin = "allowedOrigin";

    public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<AppDbContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("CommandConString")
            ));

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<ChapterType>()
                .AddType<WorkType>()
                .AddType<ParagraphType>()
                .AddType<CharacterType>()
                .AddFiltering()
                .AddSorting();

            services.AddCors(option => {
                option.AddPolicy("allowedOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(AllowedOrigin);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

            app.UseGraphQLVoyager();
        }
    }
}
