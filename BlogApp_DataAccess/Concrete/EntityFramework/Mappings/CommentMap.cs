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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i=>i.Text).IsRequired().HasMaxLength(1000);
            builder.Property(i => i.CreatedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.ModifiedByName).HasMaxLength(70).IsRequired(true);
            builder.Property(i => i.CreatedDate).IsRequired(true);
            builder.Property(i => i.ModifiedDate).IsRequired(true);
            builder.Property(i => i.IsActive).IsRequired(true);
            builder.Property(i => i.IsDeleted).IsRequired(true);
            builder.Property(i => i.Note).HasMaxLength(500);

            builder.HasOne<Article>(i => i.Article).WithMany(i => i.Comments).HasForeignKey(i => i.ArticleId);

            builder.HasData(new Comment()
            {
                Id = 1,
                ArticleId = 1,
                Text = "Çok güzel",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Blog Kategorisi"
            },
            new Comment()
            {
                Id = 2,
                ArticleId = 2,
                Text = "Çok güzel içerikler olmuş",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Java Blog Kategorisi"
            });

            builder.ToTable("Comments");
        }
    }
}
