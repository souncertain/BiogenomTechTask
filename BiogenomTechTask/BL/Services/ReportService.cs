using AutoMapper;
using BiogenomTechTask.BL.Services.Interfaces;
using BiogenomTechTask.Data.Repositories.Interfaces;
using BiogenomTechTask.Domain.Entities;
using BiogenomTechTask.Domain.Models;

namespace BiogenomTechTask.BL.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _repository;
        private readonly IMapper _mapper;
        public ReportService(IReportRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ReportModel> GetLastReport()
        {
            var result = await _repository.GetLastReport();
            return _mapper.Map<ReportModel>(result);
        }
    }
}
