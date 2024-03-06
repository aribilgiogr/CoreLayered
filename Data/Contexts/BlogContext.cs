using Core.Concretes.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
