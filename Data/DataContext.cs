using Microsoft.EntityFrameworkCore;
using WebApiCRUD.Domain;

namespace WebApiCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
        : base(opts) { }

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly, t => t.Namespace == "WebApiCRUD.Domain");
        }
    }
}
