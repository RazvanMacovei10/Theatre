using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;

        public UserController(IUserBL userBL)
        {
            _userBL = userBL;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User newUser)
        {
            if (newUser == null)
            {
                return BadRequest();
            }

            await _userBL.CreateAsync(newUser);
            return Ok();
        }
    }
}
