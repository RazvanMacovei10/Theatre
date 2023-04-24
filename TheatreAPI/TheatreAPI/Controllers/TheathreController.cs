using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using TheatreAPI.BusinessLogic;
using TheatreAPI.DTOs;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheathreController : ControllerBase
    {
        private readonly ITheathreBL _theathreBL;
        private readonly IPlayBL _playBL;
        private readonly IMapper _mapper;
        public TheathreController(ITheathreBL theathreBL, IPlayBL playBL, IMapper mapper)
        {
            _theathreBL = theathreBL;
            _playBL = playBL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTheathres()
        {
            List<Theatre> theatres = (List<Theatre>)await _theathreBL.GetAllAsync("User", "Address", "Events", "User.Role", "Events.Play");
            List<TheathreDTO> theathresDTO = _mapper.Map<List<TheathreDTO>>(theatres);
            return Ok(theathresDTO);
        }
    }
}
