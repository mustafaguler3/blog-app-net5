using BlogApp_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>>
    }
}
