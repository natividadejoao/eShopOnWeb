using Application.Entities.Whilists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infras.Data.Configuration.Whilists
{
    public class WhilistBasketConfiguration : IEntityTypeConfiguration<WhilistBasket>
    {
        public void Configure(EntityTypeBuilder<WhilistBasket> builder)
        {
             var navigation = builder.Metadata.FindNavigation(nameof(WhilistBasket.baskets));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.idBuyer)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}