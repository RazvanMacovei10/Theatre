using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketBL _ticketBL;
        public TicketController(ITicketBL ticketBL)
        {
            _ticketBL = ticketBL;
        }
    }
}
