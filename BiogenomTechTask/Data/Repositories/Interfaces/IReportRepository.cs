using BiogenomTechTask.Domain.Entities;

namespace BiogenomTechTask.Data.Repositories.Interfaces
{
    public interface IReportRepository
    {
        Task<Report> GetLastReport();
        Task Save();
    }
}
