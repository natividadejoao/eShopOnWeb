using Application.Entities.Baskets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infras.Data.Configuration.Baskets
{
    public class ProBasketConfiguration : IEntityTypeConfiguration<ProBasket>
    {
        public void Configure(EntityTypeBuilder<ProBasket> builder)
        {
             var navigation = builder.Metadata.FindNavigation(nameof(ProBasket.basketItems));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.idBuyer)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}