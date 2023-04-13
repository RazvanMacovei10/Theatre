using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.BusinessLogic;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayController : ControllerBase
    {
        private readonly IPlayBL _playBL;
        public PlayController(IPlayBL playBL)
        {
            _playBL = playBL;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Play play)
        {
            if (play == null)
            {
                return BadRequest();
            }

            await _playBL.CreateAsync(play);
            return Ok();
        }
        [HttpGet]

        public async Task<IList<Play>> GetPlays()
        {
            var plays = await _playBL.GetAllAsync();
            return plays;
        }
    }

}
