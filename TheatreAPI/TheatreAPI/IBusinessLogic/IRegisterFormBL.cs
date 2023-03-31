using TheatreAPI.Models;

namespace TheatreAPI.IBusinessLogic
{
    public interface IRegisterFormBL:IGenericBL<RegisterForm>
    {
        public Task<RegisterForm> GetById(int id);
    }
}
