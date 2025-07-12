using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiogenomTechTask.Data.Configurations
{
    public class VitaminProductConfiguration : IEntityTypeConfiguration<VitaminProduct>
    {
        public void Configure(EntityTypeBuilder<VitaminProduct> builder)
        {
            builder.HasKey(vp => vp.Id);

            builder.HasOne(vp => vp.Product)
                .WithMany(p => p.VitaminProducts)
                .HasForeignKey(vp => vp.ProductId);

            builder.HasOne(vp => vp.Vitamin)
                .WithMany(v => v.VitaminProduct)
                .HasForeignKey(vp => vp.VitaminId);
        }
    }
}
