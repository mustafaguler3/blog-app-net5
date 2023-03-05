using BlogApp_Business.Abstract;
using BlogApp_Business.Concrete;
using BlogApp_DataAccess.Abstract;
using BlogApp_DataAccess.Concrete;
using BlogApp_DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IArticleService, ArticleService>();

            return services;
        }
    }
}
