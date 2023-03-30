using TheatreAPI.IBusinessLogic;
using TheatreAPI.Models;
using TheatreAPI.Repository;

namespace TheatreAPI.BusinessLogic
{
    public class RegisterFormBL:GenericBL<IRegisterFormRepository,RegisterForm>,IRegisterFormBL
    {
        public RegisterFormBL(IRegisterFormRepository registerFormRepository):base(registerFormRepository)
        {

        }
    }
}
