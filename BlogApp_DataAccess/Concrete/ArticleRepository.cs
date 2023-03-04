using BlogApp_DataAccess.Abstract;
using BlogApp_Entities.Concrete;
using BlogApp_Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_DataAccess.Concrete
{
    public class ArticleRepository : EntityRepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
