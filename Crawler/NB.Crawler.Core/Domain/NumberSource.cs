using System;

namespace NB.Crawler.Core.Domain
{
    public sealed class NumberSource : BaseEntity
    {
        public NumberSource() : base() { }

        public NumberSource(int id) : base(id) { }

        public string Code { get; set; }

        public string Url { get; set; }

        public string Data { get; set; }

        public DateTime CreatedOnUtc { get; set; }
    }
}
