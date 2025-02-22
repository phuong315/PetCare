using Microsoft.EntityFrameworkCore;

namespace PetCareServicesApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PetCareServicesApp.Models.Order> Orders { get; set; }
        public DbSet<PetCareServicesApp.Models.Product> Products { get; set; }
    }
}