using BlogApp_Entities.Concrete;
using BlogApp_Entities.Dtos;
using BlogApp_Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Business.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<Article>> Get(int articleId);
        Task<IDataResult<IList<Article>>> GetAll();
        Task<IDataResult<IList<Article>>> GetAllByNonDelete();
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int articleId);
    }
}
