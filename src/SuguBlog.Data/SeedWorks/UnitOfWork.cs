using SuguBlog.Core.SeedWorks;

namespace SuguBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SuguBlogContext _context;

        public UnitOfWork(SuguBlogContext context)
        {
            _context = context;
        }
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
