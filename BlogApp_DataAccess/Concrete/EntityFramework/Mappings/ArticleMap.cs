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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Title).HasMaxLength(100);
            builder.Property(i => i.Title).IsRequired(true);
            builder.Property(i=>i.Content).IsRequired(true).HasColumnType("NVARCHAR(MAX)");//100 kelimede paylaşabiliriz 50 de nekadar alabiliyorsa okadar yazalım
            builder.Property(i=>i.SeoAuthor).HasMaxLength(100).IsRequired(true);
            builder.Property(i=>i.SeoDescription).HasMaxLength(100).IsRequired(true);
            builder.Property(i => i.SeoTags).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.Thumbnail).HasMaxLength(250).IsRequired(true);
            builder.Property(i => i.CreatedByName).HasMaxLength(50).IsRequired(true);
            builder.Property(i => i.CreatedDate).IsRequired(true);
            builder.Property(i => i.ModifiedDate).IsRequired(true);
            builder.Property(i => i.IsActive).IsRequired(true);
            builder.Property(i => i.IsDeleted).IsRequired(true);
            builder.Property(i => i.Note).HasMaxLength(500);
            builder.HasOne<Category>(i => i.Category).WithMany(i => i.Articles).HasForeignKey(i=>i.CategoryId);
            builder.HasOne<User>(i => i.User).WithMany(i => i.Articles).HasForeignKey(i => i.UserId);
            builder.ToTable("Articles");
        }
    }
}
