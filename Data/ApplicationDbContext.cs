using EshopApi.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EshopApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }

        public DbSet<CompanyKeys> CompanyKeys { get; set; }
        public DbSet<PurchaseOrderHeaders> PurchaseOrderHeaders { get; set; }
        public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }
    }
}
