using Application.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infras.Data.Configuration.Orders
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            
            builder.Property(ci => ci.id)
            .IsRequired();
            

            builder.Property(ci => ci.total)
            .IsRequired()
            .IsRowVersion();

            builder.Property(ci => ci.baskets)
            .IsRequired(true);

            builder.Property(ci => ci.status)
            .IsRequired(false)
            .IsRowVersion();

            builder.Property(ci => ci.idBuyer)
            .IsRequired();
            
            builder.OwnsOne(o => o.address, a =>
            {
                a.WithOwner();
                 
                a.Property(b => b.zipCode)
                    .HasMaxLength(18)
                    .IsRequired();

                a.Property(b => b.street)
                    .HasMaxLength(180)
                    .IsRequired();

                a.Property(b => b.state)
                    .HasMaxLength(60);

                a.Property(b => b.country)
                    .HasMaxLength(90)
                    .IsRequired();

                a.Property(b => b.city)
                    .HasMaxLength(100)
                    .IsRequired(); 
            });
        }
    }
}