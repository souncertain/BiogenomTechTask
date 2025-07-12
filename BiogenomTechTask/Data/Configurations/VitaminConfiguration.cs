using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiogenomTechTask.Data.Configurations
{
    public class VitaminConfiguration : IEntityTypeConfiguration<Vitamin>
    {
        public void Configure(EntityTypeBuilder<Vitamin> builder)
        {
            builder.HasKey(v => v.Id);

            builder.HasMany(v => v.VitaminProduct)
                .WithOne(vp => vp.Vitamin)
                .HasForeignKey(vp => vp.VitaminId);

            builder.HasMany(v => v.VitaminReports)
                .WithOne(vr => vr.Vitamin)
                .HasForeignKey(vr => vr.IdVitamin);
        }
    }
}
