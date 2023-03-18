using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheathreController : ControllerBase
    {
        private readonly ITheathreBL _theathreBL;
        public TheathreController(ITheathreBL theathreBL)
        {
            _theathreBL = theathreBL;
        }
    }
}
