using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientTransfer.Business;

namespace PatientTransfer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet("report")]
        public async Task<IActionResult> GetReport(DateTime startDate, DateTime endDate)
        {
            var report = await _transferService.GetReportAsync(startDate, endDate);
            return Ok(report);
        }
    }
}