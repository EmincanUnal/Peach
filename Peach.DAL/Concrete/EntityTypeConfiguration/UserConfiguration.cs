using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peach.Model.Entites;
using Peach.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.EntityTypeConfiguration
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Password).HasMaxLength(100).IsRequired();
            builder.Property(a => a.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Address).HasMaxLength(100).IsRequired();
            builder.Property(a => a.PhoneNumber).HasMaxLength(100).IsRequired();
            builder.HasIndex(a => a.Email).IsUnique();

            builder.HasData(new User
            {
                ID = 1,
                FirstName="Emincan",
                LastName="Ünal",
                Email="unalemincan96@gmail.com",
                Password="12345",
                Address="Bizimev",
                Role=UserRole.Admin,
                PhoneNumber="05386086582",
                IsActive=true
            });

        }
    }
}
