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
        private readonly IMapper _mapper;
        public RegisterFormController(IRegisterFormBL registerFormBL,IMapper mapper)
        {
            _registerFormBL = registerFormBL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegisterForms() 
        {
            List<RegisterForm> forms= (List<RegisterForm>)await _registerFormBL.GetAllAsync("Address");
            List<RegisterFormDTO> formsDTO= _mapper.Map<List<RegisterFormDTO>>(forms);
            return Ok(formsDTO);
        }
    }
}
