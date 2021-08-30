using System.Linq;
using CommanderGQL.Models;
using CommanderQQL.Data;
using HotChocolate;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}