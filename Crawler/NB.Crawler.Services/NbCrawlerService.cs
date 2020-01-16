using Microsoft.EntityFrameworkCore;
using MrdLibraries.Data;
using NB.Crawler.Core.Domain;
using System;
using System.Linq;
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

        public async Task<bool> HasDataAsync(DateTime date)
        {
            var query = from numberSource in _numberSourceRepository.Table
                where numberSource.CreatedOnUtc == date
                select numberSource;
            var result = await query.AnyAsync();
            return result;
        }
    }
}
