using HelpingHands.Entities;
using HelpingHands.Services.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpingHands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigins")]
    public class NeedsController : ControllerBase
    {
        private readonly INeedService _needService;

        public NeedsController(INeedService needService)
        {
            _needService = needService;
        }
        [HttpGet("needs")]
        public async Task<ActionResult<IEnumerable<Need>>> GetNeeds() 
        {
            return Ok(await _needService.GetNeeds());
        }
    }
}
