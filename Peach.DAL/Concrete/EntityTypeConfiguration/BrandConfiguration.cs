using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.EntityTypeConfiguration
{
    class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.CompanyName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(256).IsRequired();
        }
    }
}
