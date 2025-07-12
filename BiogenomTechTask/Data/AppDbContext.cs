using BiogenomTechTask.Data.Configurations;
using BiogenomTechTask.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTechTask.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vitamin>Vitamins { get; set; }
        public DbSet<VitaminProduct> VitaminProducts { get; set; }
        public DbSet<VitaminReport> VitaminReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminProductConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminReportConfiguration());
        }

    }
}
