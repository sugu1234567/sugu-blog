using AutoMapper;
using SuguBlog.Core.Repositories;
using SuguBlog.Core.SeedWorks;
using SuguBlog.Data.Repositories;

namespace SuguBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SuguBlogContext _context;

        public UnitOfWork(SuguBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(_context, mapper);
        }

        public IPostRepository Posts { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
