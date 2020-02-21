using Application.Entities.Baskets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infras.Data.Configuration.Baskets
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Basket.basketItems));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(b => b.idBuyer)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}