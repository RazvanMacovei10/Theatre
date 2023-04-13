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
        private readonly ITheathreBL _theathreBL;
        public PlayController(IPlayBL playBL, IMapper mapper,ITheathreBL theathreBL)
        {
            _playBL = playBL;
            _mapper = mapper;
            _theathreBL = theathreBL;
        }
        [HttpPost("{name}")]
        public async Task<IActionResult> Create([FromBody] PlayDTO playDTO,string name)
        {
            Play play = _mapper.Map<Play>(playDTO);
            play.Theatre = await _theathreBL.GetByUsername(name);
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


        [HttpGet("{name}")]
        public async Task<IActionResult> GetEventsByTheatreId(string name)
        {
            List<Play> plays = (List<Play>)await _playBL.GetAllAsync("Theatre", "Theatre.User");
            plays = plays.Where(e => e.Theatre.User.Username == name).ToList();
            List<PlayDTO> playsDTO = _mapper.Map<List<PlayDTO>>(plays);
            return Ok(playsDTO);
        }
    }

}
