using BiogenomTechTask.BL.Services.Interfaces;
using BiogenomTechTask.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiogenomTechTask.Controllers
{
    [ApiController]
    [Route("/report")]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService) { _reportService = reportService; }
        // GET: ReportController
        [HttpGet]
        public async Task<ReportModel> Get()
        {
            return await _reportService.GetLastReport();
        }
    }
}
