using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using TheatreAPI.DTOs;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserBL _userBL;
        private readonly ITokenBL _tokenBL;
        private readonly IRegisterFormBL _registerFormBL;
        public AccountController(IUserBL userBL, ITokenBL tokenBL,IRegisterFormBL registerFormBL)
        {
            _userBL = userBL;
            _tokenBL = tokenBL;
            _registerFormBL = registerFormBL;
        }
        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
        {

            if (await _userBL.UserExists(registerDTO.Username))
            {
                return BadRequest("Username is taken");
            }
            if (await _userBL.UserExistsByEmail(registerDTO.Email))
            {
                return BadRequest("Email is taken");
            }
            using var hmac = new HMACSHA512();

            var user = new User()
            {
                Username = registerDTO.Username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password)),
                PasswordSalt = hmac.Key,
                Email = registerDTO.Email.ToLower(),
                RoleId = 1
            };
            _userBL.CreateAsync(user);
            return new UserDTO
            {
                Username = user.Username,
                Token = _tokenBL.CreateToken(user)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = _userBL.GetByUsername(loginDTO.Username);

            if (user.Result == null) return Unauthorized("invalid username");

            using var hmac = new HMACSHA512(user.Result.PasswordSalt);

            var computedhash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));

            for (int i = 0; i < computedhash.Length; i++)
            {
                if (computedhash[i] != user.Result.PasswordHash[i]) return Unauthorized("invalid password");
            }
            return new UserDTO
            {
                Username = user.Result.Username,
                Token = _tokenBL.CreateToken(user.Result)
            };
        }

    }
}
