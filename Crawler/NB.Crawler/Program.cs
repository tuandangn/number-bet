using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MrdLibraries.Data;
using NB.Crawler.Data;
using NB.Crawler.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NB.Crawler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<NbCrawlerDbContext>(opts =>
                        opts.UseSqlServer(hostContext.Configuration.GetConnectionString(nameof(NbCrawlerDbContext))));
                    services.AddScoped<IDbContext, NbCrawlerDbContext>();
                    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

                    //services
                    services.AddTransient<INbCrawlerService, NbCrawlerService>();

                    services.AddHostedService<Worker>();
                });
    }
}
