using depooo.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace depooo.Server.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
