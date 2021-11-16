using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Models
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options) : base(options)
        {
        }

        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Department> Department { get; set; }        
    }
}
