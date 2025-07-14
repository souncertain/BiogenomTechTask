using BiogenomTechTask.Data.Configurations;
using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTechTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product>Products { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vitamin>Vitamins { get; set; }
        public DbSet<VitaminProduct> VitaminProducts { get; set; }
        public DbSet<VitaminReport> VitaminReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable(nameof(Product));
            modelBuilder.Entity<Report>().ToTable(nameof(Report));
            modelBuilder.Entity<User>().ToTable(nameof(User));
            modelBuilder.Entity<Vitamin>().ToTable(nameof(Vitamin));
            modelBuilder.Entity<VitaminProduct>().ToTable(nameof(VitaminProduct));
            modelBuilder.Entity<VitaminReport>().ToTable(nameof(VitaminReport));

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminProductConfiguration());
            modelBuilder.ApplyConfiguration(new VitaminReportConfiguration());
        }

    }
}
