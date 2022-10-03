using FirstRepositoryPatternApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstRepositoryPatternApi.Data
{
    public class RepoDbContext : DbContext
    {
        public RepoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
