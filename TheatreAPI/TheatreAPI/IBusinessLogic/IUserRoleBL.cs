using TheatreAPI.Models;

namespace TheatreAPI.IBusinessLogic
{
    public interface IUserRoleBL:IGenericBL<UserRole>
    {
        public Task<UserRole> GetById(int id);
    }
}
