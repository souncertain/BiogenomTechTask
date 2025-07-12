using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiogenomTechTask.Data.Configurations
{
    public class VitaminReportConfiguration : IEntityTypeConfiguration<VitaminReport>
    {
        public void Configure(EntityTypeBuilder<VitaminReport> builder)
        {
            builder.HasKey(vr => vr.Id);

            builder.HasOne(vr => vr.Report)
                .WithMany(r => r.VitaminReports)
                .HasForeignKey(vr => vr.IdReport);

            builder.HasOne(vr => vr.Vitamin)
                .WithMany(v => v.VitaminReports)
                .HasForeignKey(vr => vr.IdVitamin);
        }
    }
}
