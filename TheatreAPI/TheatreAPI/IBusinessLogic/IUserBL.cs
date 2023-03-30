using TheatreAPI.Models;

namespace TheatreAPI.IBusinessLogic
{
    public interface IUserBL:IGenericBL<User>
    {
        public Task<User> GetById(int userId);

        public Task<bool> UserExists(string username);

        public Task<User> GetByUsername(string username);
        public Task<bool> UserExistsByEmail(string email);
    }
}
