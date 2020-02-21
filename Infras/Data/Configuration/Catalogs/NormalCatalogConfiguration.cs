using Application.Entities.Catalogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infras.Data.Configuration.Catalogs
{
    public class NormalCatalogConfiguration : IEntityTypeConfiguration<NormalCatalog>
    {
        public void Configure(EntityTypeBuilder<NormalCatalog> builder)
        {
             var navigation = builder.Metadata.FindNavigation(nameof(NormalCatalog.catalogItem));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.idCatalog)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(b => b.dateCreation)
            .IsRequired(true)
            .HasMaxLength(40);


            builder.Property(b => b.pages)
            .IsRequired()
            .IsRowVersion();

           
            builder.HasOne(b => b.catalogItem)
                .WithMany()
                .HasForeignKey(b => b.idCatalogItem);

        }
    }
}