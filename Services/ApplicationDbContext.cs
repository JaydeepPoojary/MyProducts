using Microsoft.EntityFrameworkCore;
using MyProducts.Models;

namespace MyProducts.Services
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
