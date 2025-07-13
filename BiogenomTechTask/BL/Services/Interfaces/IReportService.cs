using BiogenomTechTask.Domain.Models;

namespace BiogenomTechTask.BL.Services.Interfaces
{
    public interface IReportService
    {
        Task <ReportModel> GetLastReport();
    }
}
