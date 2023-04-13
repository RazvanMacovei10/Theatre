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
    public class EventController : ControllerBase
    {
        private readonly IEventBL _eventBL;
        private readonly ITheathreBL _theathreBL;
        private readonly IMapper _mapper;
        public EventController(IEventBL eventBL, IMapper mapper, ITheathreBL theathreBL)
        {
            _eventBL = eventBL;
            _mapper = mapper;
            _theathreBL = theathreBL;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EventSentDTO eventDTO)
        {
            Theatre theatre = await _theathreBL.GetByUsername(eventDTO.TheatreName);
            Event newEvent = _mapper.Map<Event>(eventDTO);
            newEvent.Theatre = theatre;
            newEvent.TheatreId = theatre.Id;
            newEvent.AvailableSeats = theatre.TotalSeats;

            await _eventBL.CreateAsync(newEvent);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            List<Event> forms = (List<Event>)await _eventBL.GetAllAsync("Theatre", "Play", "Theatre.User");
            List<EventDTO> formsDTO = _mapper.Map<List<EventDTO>>(forms);
            return Ok(formsDTO);
        }
    }
}
