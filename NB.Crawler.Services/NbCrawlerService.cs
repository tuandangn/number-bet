using MrdLibraries.Data;
using NB.Crawler.Core.Domain;
using System;
using System.Threading.Tasks;

namespace NB.Crawler.Services
{
    public sealed class NbCrawlerService : INbCrawlerService
    {
        private readonly IRepository<NumberSource> _numberSourceRepository;

        public NbCrawlerService(IRepository<NumberSource> numberSourceRepository)
        {
            _numberSourceRepository = numberSourceRepository;
        }

        public Task<NumberSource> GetDataAsync(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasDataAsync(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
