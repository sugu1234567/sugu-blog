using SuguBlog.Core.Models;
using SuguBlog.Core.Models.Content;
using SuguBlog.Core.SeedWorks;
using SuguBlog.Data.Domain.Content;

namespace SuguBlog.Core.Repositories
{
    public interface IPostRepository: IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
