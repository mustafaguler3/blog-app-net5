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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Name).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.Description).HasMaxLength(500);
            builder.Property(i => i.CreatedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.ModifiedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.CreatedDate).IsRequired(true);
            builder.Property(i => i.ModifiedDate).IsRequired(true);
            builder.Property(i => i.IsActive).IsRequired(true);
            builder.Property(i => i.IsDeleted).IsRequired(true);
            builder.Property(i => i.Note).HasMaxLength(500);
            builder.ToTable("Categories");

        }
    }
}
