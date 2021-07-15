using ExaLearn.Bl.DTO;
using ExaLearn.Bl.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaLearn.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryService _historyService;

        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpPost]
        public async Task<IActionResult> GetHistoryAsync(HistoryDTO historyDTO)
        {
            return Ok(await _historyService.AddAsync(historyDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoryAsync(int id)
        {
            return Ok(await _historyService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHistoryAsync()
        {
            return Ok(await _historyService.GetAllAsync());
        }
    }
}
