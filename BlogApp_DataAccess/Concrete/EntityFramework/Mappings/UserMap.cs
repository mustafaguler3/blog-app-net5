using BlogApp_Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(i => i.Email).IsUnique();
            builder.Property(i => i.Username).IsRequired().HasMaxLength(50);
            builder.HasIndex(i => i.Username).IsUnique();
            builder.Property(i => i.PasswordHash).IsRequired().HasColumnType("VARBINARY(500)");
            builder.Property(i => i.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.LastName).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Picture).IsRequired().HasMaxLength(250);
            builder.Property(i => i.Description).HasMaxLength(500);
            builder.Property(i => i.CreatedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.ModifiedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.CreatedDate).IsRequired(true);
            builder.Property(i => i.ModifiedDate).IsRequired(true);
            builder.Property(i => i.IsActive).IsRequired(true);
            builder.Property(i => i.IsDeleted).IsRequired(true);
            builder.Property(i => i.Note).HasMaxLength(500);
            builder.ToTable("Users");
        }
    }
}
