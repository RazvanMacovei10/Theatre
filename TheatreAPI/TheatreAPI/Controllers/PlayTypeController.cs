using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayTypeController : ControllerBase
    {
        private readonly IPlayTypeBL _playTypeBL;
        public PlayTypeController(IPlayTypeBL playTypeBL)
        {
            _playTypeBL = playTypeBL;
        }
    }
}
