using Microsoft.EntityFrameworkCore;

namespace Blog.Db
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
    }
}
