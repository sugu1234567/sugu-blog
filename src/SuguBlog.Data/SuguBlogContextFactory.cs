using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SuguBlog.Data
{
    public class SuguBlogContextFactory : IDesignTimeDbContextFactory<SuguBlogContext>
    {
        public SuguBlogContext CreateDbContext(string[] args)
        {
            // Load config từ appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())      // lấy folder hiện tại
                .AddJsonFile("appsettings.json")                   // đọc file appsettings.json
                .Build();
            // Tạo DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<SuguBlogContext>();

            // Cấu hình dùng SQL Server với connection string "DefaultConnection"
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            // Trả về instance của DbContext
            return new SuguBlogContext(builder.Options);
        }
    }
}
