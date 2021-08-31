using System.Linq;
using CommanderGQL.Models;
using CommanderGQL.Data;
using HotChocolate;
using HotChocolate.Data;
namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}