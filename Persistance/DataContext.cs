using EYCaseStudy.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EYCaseStudy.API.Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<Period> Periods { get; set; }
    }
}