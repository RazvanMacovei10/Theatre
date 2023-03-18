using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.IBusinessLogic;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleBL _userRoleBL;

        public UserRoleController(IUserRoleBL userRoleBL)
        {
            _userRoleBL = userRoleBL;
        }
    }
}
