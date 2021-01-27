using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.EntityTypeConfiguration
{
    class ClothingConfiguration : IEntityTypeConfiguration<Clothing>
    {
        public void Configure(EntityTypeBuilder<Clothing> builder)
        {
            builder.ToTable("Clothing");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();
            builder.Property(a => a.ClothesArtUrl).HasMaxLength(256);
            builder.Property(a => a.Price).HasPrecision(10,2);



        }
    }
}
