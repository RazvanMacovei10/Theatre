using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.BusinessLogic;
using TheatreAPI.DTOs;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayController : ControllerBase
    {
        private readonly IPlayBL _playBL;
        private readonly IMapper _mapper;
        public PlayController(IPlayBL playBL, IMapper mapper)
        {
            _playBL = playBL;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlayDTO playDTO)
        {
            Play play = _mapper.Map<Play>(playDTO);

            await _playBL.CreateAsync(play);
            return Ok();
        }

        [HttpGet]
        public async Task<IList<Play>> GetPlays()
        {
            var plays = await _playBL.GetAllAsync();
            return plays;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlay(int id)
        {
            await _playBL.DeleteAsync(id);
            return Ok();
        }
    }

}
