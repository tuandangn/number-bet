using System;
using Moq;
using MrdLibraries.Data;
using NB.Crawler.Core.Domain;
using Xunit;
using MrdLibraries.TestUtilities;

namespace NB.Crawler.Services.Tests
{
    public class NbCrawlerServiceTests
    {
        [Fact]
        public async void HasDataAsync()
        {
            var checkDate = DateTime.UtcNow;
            NumberSource[] availableNumberSources = new[] {
                new NumberSource { CreatedOnUtc = DateTime.UtcNow}
            };
            var numberSourceRepositoryMock = new Mock<IRepository<NumberSource>>();
            numberSourceRepositoryMock.Setup(r => r.Table).Returns(availableNumberSources.ToAsync())
                .Verifiable();
            var nbCrawlerService = new NbCrawlerService(numberSourceRepositoryMock.Object);

            var result = await nbCrawlerService.HasDataAsync(checkDate);

            Assert.True(result);
            numberSourceRepositoryMock.Verify();
        }
    }
}
