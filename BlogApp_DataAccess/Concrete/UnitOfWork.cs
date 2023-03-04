using BlogApp_DataAccess.Abstract;
using BlogApp_DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private ArticleRepository _articleRepository;
        private CommentRepository _commentRepository;
        private RoleRepository _roleRepository;
        private UserRepository _userRepository;
        private CategoryRepository _categoryRepository;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }

        public IArticleRepository Articles => _articleRepository ?? new ArticleRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new CategoryRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new CommentRepository(_context);

        public IUserRepository Users => _userRepository?? new UserRepository(_context);

        public IRoleRepository Roles =>_roleRepository ?? new RoleRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
