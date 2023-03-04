using BlogApp_Entities.Concrete;
using BlogApp_Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_DataAccess.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
