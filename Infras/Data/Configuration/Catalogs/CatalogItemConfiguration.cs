using Application.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infras.Data.Configuration.Catalogs
{
    public class CatalogItemConfiguration : IEntityTypeConfiguration<CatalogItem>
    {
        public void Configure(EntityTypeBuilder<CatalogItem> builder)
        {
             builder.ToTable("NormalCatalog");
             builder.ToTable("SpecialCatlog");

            builder.Property(ci => ci.id)
                .UseHiLo("catalog_hilo")
                .IsRequired();

            builder.Property(ci => ci.quantity)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(ci => ci.price)
                .IsRequired(true)
                .HasColumnType("decimal(18,2)");

            builder.Property(ci => ci.pictureUri)
                .IsRequired(false);

            builder.Property(ci => ci.descrition)
            .IsRequired(true);



            
        }
    }
}