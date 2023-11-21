using Microsoft.EntityFrameworkCore;

namespace WebApiCRUD.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> opts) 
        :base (opts){ }

        public DbSet<Product> Products => Set<Product>();
    }
}
