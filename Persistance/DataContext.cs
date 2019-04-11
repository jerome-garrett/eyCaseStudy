using System.ComponentModel.DataAnnotations.Schema;
using EYCaseStudy.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EYCaseStudy.API.Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Sale> Sales { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<Period> Periods { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // handle computed column in Sales table
            builder.Entity<Sale>()
                .Property(s => s.TotalPrice)
                .HasComputedColumnSql("QuantitySold * UnitPrice");
                
        }
    }
}