using Application.Entities.Whilists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infras.Data.Configuration.Whilists
{
    public class WhilistCatalogConfiguration : IEntityTypeConfiguration<WhilistCatalog>
    {
        public void Configure(EntityTypeBuilder<WhilistCatalog> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(WhilistCatalog.items));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.idBuyer)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}