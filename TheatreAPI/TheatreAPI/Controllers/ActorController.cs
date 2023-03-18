using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorBL _actorBL;
        public ActorController(IActorBL actorBL)
        {
            _actorBL = actorBL;
        }
    }
}
