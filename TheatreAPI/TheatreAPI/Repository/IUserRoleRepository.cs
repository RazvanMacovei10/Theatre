using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public interface IUserRoleRepository:IGenericRepository<UserRole>
    {
        public Task<UserRole> GetById(int id);
    }
}
