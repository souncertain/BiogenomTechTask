using BiogenomTechTask.Data.Repositories.Interfaces;
using BiogenomTechTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTechTask.Data.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public ReportRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Report> GetLastReport()
        {
            return await _appDbContext.Reports
                .Include(r => r.VitaminReports)
                    .ThenInclude(vr => vr.Vitamin)
                        .ThenInclude(v => v.VitaminProduct)
                            .ThenInclude(vp => vp.Product)
                .OrderByDescending(r => r.Created)
                .FirstOrDefaultAsync();
        }

        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
