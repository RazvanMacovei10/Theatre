using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public interface IUserRepository:IGenericRepository<User>
    {
        public Task<User> GetById(int id);
        public Task<bool> UserExists(string username);

        public Task<User> GetByUsername(string username);
        public Task<bool> UserExistsByEmail(string email);
    }
}
