using SuguBlog.Core.Repositories;

namespace SuguBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {

        IPostRepository Posts { get; }
        Task<int> CompleteAsync();
    }
}
