using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheatreAPI.DTOs;
using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;

namespace TheatreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterFormController : ControllerBase
    {
        private readonly IRegisterFormBL _registerFormBL;
        private readonly IUserBL _userBL;
        private readonly ITheathreBL _theathreBL;
        private readonly IMapper _mapper;
        public RegisterFormController(IRegisterFormBL registerFormBL,IMapper mapper, IUserBL userBL, ITheathreBL theathreBL)
        {
            _registerFormBL = registerFormBL;
            _mapper = mapper;
            _userBL = userBL;
            _theathreBL = theathreBL;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegisterForms() 
        {
            List<RegisterForm> forms= (List<RegisterForm>)await _registerFormBL.GetAllAsync("Address");
            List<RegisterFormDTO> formsDTO= _mapper.Map<List<RegisterFormDTO>>(forms);
            return Ok(formsDTO);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> CreateUserFromRegisterForm(int id)
        {
            RegisterForm registerForm = await _registerFormBL.GetById(id);
            if (registerForm == null)
            {
                return BadRequest("Form not found");
            }
            User user=new User()
            {
                Username= registerForm.Username,
                Email=registerForm.Email,
                PasswordHash=registerForm.PasswordHash,
                PasswordSalt=registerForm.PasswordSalt,
                RoleId=3
            };
            user=await _userBL.CreateAsync(user);
            Theatre theatre= new Theatre()
            { 
                Address=registerForm.Address,
                TotalSeats=registerForm.TotalSeats,
                Image=registerForm.Image,
                User=user
            };
            await _theathreBL.CreateAsync(theatre);
            await _registerFormBL.DeleteAsync(id);
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForm(int id) 
        {
            await _registerFormBL.DeleteAsync(id);
            return Ok();
        }
    }
}
