using CommanderGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderQQL.Data
{
  public class AppDbContext: DbContext
  {
    public AppDbContext(DbContextOptions options) :base(options)
    {
    }

    public DbSet<Platform> Platforms { get; set; }
  }
}