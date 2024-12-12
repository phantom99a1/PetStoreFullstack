using Microsoft.EntityFrameworkCore;
using WebUI.Entities;

namespace WebUI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
