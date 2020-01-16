using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NB.Crawler.Core.Domain;

namespace NB.Crawler.Data.Mappings
{
    public sealed class NumberSourceMap : IEntityTypeConfiguration<NumberSource>
    {
        public void Configure(EntityTypeBuilder<NumberSource> builder)
        {
            builder.ToTable("NumberSource", "number");
            builder.HasKey(ns => ns.Id);

            builder.Property(ns => ns.Url).HasMaxLength(1000).IsRequired();
            builder.Property(ns => ns.Code).HasMaxLength(100).IsRequired();
            builder.Property(ns => ns.Data).IsRequired();
        }
    }
}
