using Microsoft.EntityFrameworkCore;
using MrdLibraries.Data;

namespace NB.Crawler.Data
{
    public sealed class NbCrawlerDbContext : DbContext, IDbContext
    {
        public NbCrawlerDbContext(DbContextOptions<NbCrawlerDbContext> opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NbCrawlerDbContext).Assembly);
        }
    }
}
