using NB.Crawler.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NB.Crawler.Services
{
    public interface INbCrawlerService
    {
        Task<bool> HasDataAsync(DateTime date);

        Task<NumberSource> GetDataAsync(DateTime date);
    }
}
