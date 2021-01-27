using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.EntityTypeConfiguration
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.ShipAddress).HasMaxLength(250).IsRequired();

        }
    }
}
