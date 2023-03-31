using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public interface IRegisterFormRepository:IGenericRepository<RegisterForm>
    {
        public Task<RegisterForm> GetById(int id);
    }
}
