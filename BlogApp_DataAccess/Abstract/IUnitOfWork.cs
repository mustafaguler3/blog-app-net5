using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; } 
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IUserRepository Users { get; }
        IRoleRepository Roles { get; }
        Task<int> SaveAsync();
    }
}
