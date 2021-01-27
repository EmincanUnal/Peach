using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.EntityTypeConfiguration
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(a => new { a.ClothingID, a.OrderID });
            builder.Property(a => a.Price).HasPrecision(10, 2);
        }
    }
}
