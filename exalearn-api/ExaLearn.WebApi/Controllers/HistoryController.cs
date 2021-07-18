using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/histories")]
    [ApiController]
    [Authorize]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryService _historyService;

        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpPost]
        public async Task<IActionResult> GetHistory([FromBody] HistoryDTO historyDTO)
        {
            return Ok(await _historyService.AddAsync(historyDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoryById(int id)
        {
            return Ok(await _historyService.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHistory()
        {
            return Ok(await _historyService.GetAllAsync());
        }
    }
}
