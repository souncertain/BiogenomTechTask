using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiogenomTechTask.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.VitaminProducts)
                .WithOne(vp => vp.Product)
                .HasForeignKey(vp => vp.ProductId);
        }
    }
}
